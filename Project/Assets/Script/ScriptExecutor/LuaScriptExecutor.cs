using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using LuaInterface;

public class LuaScriptExecutor : IScriptExecutor
{

    private LuaState mState;
    private bool mInitialized = false;

    public override bool IsGood
    {
        get { return mInitialized; }
    }

    public override bool Init(params string [] args)
    {
        mInitialized = false;
        mState = new LuaState();
        // open libraries
#if LUAC_5_3
#else
        mState.OpenLibs(LuaDLL.luaopen_bit);
#endif
        mState.OpenLibs(LuaDLL.luaopen_lpeg);
        mState.OpenLibs(LuaDLL.luaopen_struct);

        mState.BeginPreLoad();
        mState.RegFunction("socket.core", LuaDLL.luaopen_socket_core);
        mState.RegFunction("mime.core", LuaDLL.luaopen_mime_core);
        mState.EndPreLoad();

        mState.LuaGetField(LuaIndexes.LUA_REGISTRYINDEX, "_LOADED");
        mState.OpenLibs(LuaDLL.luaopen_cjson);
        mState.LuaSetField(-2, "cjson");
        mState.OpenLibs(LuaDLL.luaopen_cjson_safe);
        mState.LuaSetField(-2, "cjson.safe");

        string lua_path = MainApplication.Inst.GetVariable("LUA_PATH");
        if (!string.IsNullOrEmpty(lua_path))
        {
            string[] path_list = lua_path.Split(';');
            foreach (string path in path_list)
            {
                mState.AddSearchPath(MainApplication.Inst.ValueParser.GetValue(path));
            }
        }

        // binding 
        LuaBinder.Bind(mState);
        DelegateFactory.Init();
        LuaCoroutine.Register(mState, MainApplication.Inst);

        mState.Start();


        mInitialized = true;
        // load script
        if (null != args && args.Length > 0)
        {
            try
            {
                mState.DoFile(args[0]);
            }catch(Exception ex)
            {
                Debug.LogException(ex);
                return false;
            }
        }
        return true;
    }

    public override bool Run(string scriptfile)
    {
        if (!IsGood)
            return false;
        try
        {
            mState.DoFile(scriptfile);
        }catch(Exception ex)
        {
            Debug.LogException(ex);
            return false;
        }
        return true;
    }

    public override void Call(string funcName)
    {
        if (!IsGood)
            return ;
        try
        {
            LuaFunction func = mState.GetFunction(funcName);
            if (null == func)
                return;
            func.Call();
        }catch(Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    public override void Update(float delta, float unscaled)
    {
        try
        {
            if (mState.LuaUpdate(delta, unscaled) != 0)
            {
                LuaError();
                return;
            }
            
            mState.LuaPop(1);
            //mState.Collect();
        }catch(Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    public override void LateUpdate(float delta, float unscaled)
    {
        try
        {
            if (mState.LuaLateUpdate() != 0)
            {
                LuaError();
                return;
            }
            mState.LuaPop(1);
            //mState.Collect();
        }catch(Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    public override void FixedUpdate(float delta, float unscaled)
    {
        try
        {
            if (mState.LuaFixedUpdate(delta) != 0)
            {
                LuaError();
                return;
            }
            mState.LuaPop(1);
        }catch(Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    private void LuaError()
    {
        string errmsg = mState.LuaToString(-1);
        mState.LuaPop(2);
        Debug.LogError(errmsg);
    }
}
