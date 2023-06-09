﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class main_applicationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(main_application), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("get_variable", new LuaCSFunction(get_variable));
		L.RegFunction("__eq", new LuaCSFunction(op_Equality));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("inst", new LuaCSFunction(get_inst), null);
		L.RegVar("resource", new LuaCSFunction(get_resource), null);
		L.RegVar("parser", new LuaCSFunction(get_parser), null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_variable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			main_application obj = ToLua.CheckObject<main_application>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string o = obj.get_variable(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inst(IntPtr L)
	{
		try
		{
			ToLua.Push(L, main_application.inst);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resource(IntPtr L)
	{
		main_application obj = null;
		try
		{
			obj = (main_application)ToLua.ToObject(L, 1);
			mwt.resourceloader ret = obj.resource;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index resource on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_parser(IntPtr L)
	{
		main_application obj = null;
		try
		{
			obj = (main_application)ToLua.ToObject(L, 1);
			mwt.value_parser ret = obj.parser;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index parser on a nil value");
		}
	}
}

