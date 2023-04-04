﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Networking_DownloadHandlerBufferWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Networking.DownloadHandlerBuffer), typeof(UnityEngine.Networking.DownloadHandler));
		L.RegFunction("GetContent", new LuaCSFunction(GetContent));
		L.RegFunction("New", new LuaCSFunction(_CreateUnityEngine_Networking_DownloadHandlerBuffer));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Networking_DownloadHandlerBuffer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Networking.DownloadHandlerBuffer obj = new UnityEngine.Networking.DownloadHandlerBuffer();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Networking.DownloadHandlerBuffer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetContent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Networking.UnityWebRequest arg0 = ToLua.CheckObject<UnityEngine.Networking.UnityWebRequest>(L, 1);
			string o = UnityEngine.Networking.DownloadHandlerBuffer.GetContent(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

