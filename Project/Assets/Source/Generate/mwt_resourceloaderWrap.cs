﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class mwt_resourceloaderWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(mwt.resourceloader), typeof(System.Object));
		L.RegFunction("load_asset", new LuaCSFunction(load_asset));
		L.RegFunction("bundle_path", new LuaCSFunction(bundle_path));
		L.RegFunction("New", new LuaCSFunction(_Createmwt_resourceloader));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createmwt_resourceloader(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				mwt.resourceloader obj = new mwt.resourceloader();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: mwt.resourceloader.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int load_asset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			mwt.resourceloader obj = ToLua.CheckObject<mwt.resourceloader>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			int arg1 = (int)LuaDLL.luaL_checkinteger(L, 3);
			System.Type arg2 = ToLua.CheckMonoType(L, 4);
			LuaFunction arg3 = ToLua.CheckLuaFunction(L, 5);
			long arg4 = LuaDLL.tolua_checkint64(L, 6);
			bool o = obj.load_asset(arg0, arg1, arg2, arg3, arg4);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int bundle_path(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = mwt.resourceloader.bundle_path(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

