﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_CameraClearFlagsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.CameraClearFlags));
		L.RegVar("Skybox", new LuaCSFunction(get_Skybox), null);
		L.RegVar("Color", new LuaCSFunction(get_Color), null);
		L.RegVar("SolidColor", new LuaCSFunction(get_SolidColor), null);
		L.RegVar("Depth", new LuaCSFunction(get_Depth), null);
		L.RegVar("Nothing", new LuaCSFunction(get_Nothing), null);
		L.RegFunction("ToInt", new LuaCSFunction(EnumTrait<UnityEngine.CameraClearFlags>.ToInt));
		L.RegFunction("IntToEnum", new LuaCSFunction(EnumTrait<UnityEngine.CameraClearFlags>.IntToEnum));
		L.RegFunction("CompareTo", new LuaCSFunction(EnumTrait<UnityEngine.CameraClearFlags>.CompareTo));
		L.RegFunction("ToString", new LuaCSFunction(EnumTrait<UnityEngine.CameraClearFlags>.ToString));
#if !LUAC_5_3
		L.RegEnumEqualFunction("__eq");
#endif
		L.RegFunction("Equals", new LuaCSFunction(EnumTrait<UnityEngine.CameraClearFlags>.Equals));
		L.RegFunction("__tostring", new LuaCSFunction(EnumTrait<UnityEngine.CameraClearFlags>.ToString));
		L.EndEnum();
		TypeTraits<UnityEngine.CameraClearFlags>.Check = EnumTrait<UnityEngine.CameraClearFlags>.CheckType;
		StackTraits<UnityEngine.CameraClearFlags>.Push = ToLua.PushData<UnityEngine.CameraClearFlags>;
		EnumTrait<UnityEngine.CameraClearFlags>.IntToEnumTransfer = (i) => (UnityEngine.CameraClearFlags)i;
		EnumTrait<UnityEngine.CameraClearFlags>.EnumToInt = (e) => (int)e;
	}


	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Skybox(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.CameraClearFlags.Skybox);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Color(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.CameraClearFlags.Color);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SolidColor(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.CameraClearFlags.SolidColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Depth(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.CameraClearFlags.Depth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Nothing(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.CameraClearFlags.Nothing);
		return 1;
	}
}
