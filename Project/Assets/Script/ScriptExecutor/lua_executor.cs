using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using LuaInterface;

public class lua_executor : script_executor
{

    private LuaState m_state;
    private bool m_initialized = false;

    public override bool is_good
    {
        get { return m_initialized; }
    }

    public override bool init(params string [] args)
    {
        m_initialized = false;
        m_state = new LuaState();
        // open libraries
#if LUAC_5_3
#else
        m_state.OpenLibs(LuaDLL.luaopen_bit);
#endif
        m_state.OpenLibs(LuaDLL.luaopen_lpeg);
        m_state.OpenLibs(LuaDLL.luaopen_struct);

        m_state.BeginPreLoad();
        m_state.RegFunction("socket.core", LuaDLL.luaopen_socket_core);
        m_state.RegFunction("mime.core", LuaDLL.luaopen_mime_core);
        m_state.EndPreLoad();

        m_state.LuaGetField(LuaIndexes.LUA_REGISTRYINDEX, "_LOADED");
        m_state.OpenLibs(LuaDLL.luaopen_cjson);
        m_state.LuaSetField(-2, "cjson");
        m_state.OpenLibs(LuaDLL.luaopen_cjson_safe);
        m_state.LuaSetField(-2, "cjson.safe");

        string lua_path = main_application.inst.get_variable("LUA_PATH");
        if (!string.IsNullOrEmpty(lua_path))
        {
            string[] path_list = lua_path.Split(';');
            foreach (string path in path_list)
            {
                m_state.AddSearchPath(main_application.inst.parser.get_value(path));
            }
        }

        // binding 
        LuaBinder.Bind(m_state);
        DelegateFactory.Init();
        LuaCoroutine.Register(m_state, main_application.inst);

        m_state.Start();


        m_initialized = true;
        // load script
        if (null != args && args.Length > 0)
        {
            try
            {
                m_state.DoFile(args[0]);
            }catch(Exception ex)
            {
                Debug.LogException(ex);
                return false;
            }
        }
        return true;
    }

    public override bool run(string scriptfile)
    {
        if (!is_good)
            return false;
        try
        {
            m_state.DoFile(scriptfile);
        }catch(Exception ex)
        {
            Debug.LogException(ex);
            return false;
        }
        return true;
    }

    public override void call(string funcName)
    {
        if (!is_good)
            return ;
        try
        {
            LuaFunction func = m_state.GetFunction(funcName);
            if (null == func)
                return;
            func.Call();
        }catch(Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    public override void update(float delta, float unscaled)
    {
        try
        {
            if (m_state.LuaUpdate(delta, unscaled) != 0)
            {
                LuaError();
                return;
            }

            m_state.LuaPop(1);
            //mState.Collect();
        }catch(Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    public override void late_update(float delta, float unscaled)
    {
        try
        {
            if (m_state.LuaLateUpdate() != 0)
            {
                LuaError();
                return;
            }
            m_state.LuaPop(1);
            //mState.Collect();
        }catch(Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    public override void fixed_update(float delta, float unscaled)
    {
        try
        {
            if (m_state.LuaFixedUpdate(delta) != 0)
            {
                LuaError();
                return;
            }
            m_state.LuaPop(1);
        }catch(Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    private void LuaError()
    {
        string errmsg = m_state.LuaToString(-1);
        m_state.LuaPop(2);
        Debug.LogError(errmsg);
    }
}
