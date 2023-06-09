﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_PlayModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.PlayMode));
		L.RegVar("StopSameLayer", new LuaCSFunction(get_StopSameLayer), null);
		L.RegVar("StopAll", new LuaCSFunction(get_StopAll), null);
		L.RegFunction("ToInt", new LuaCSFunction(EnumTrait<UnityEngine.PlayMode>.ToInt));
		L.RegFunction("IntToEnum", new LuaCSFunction(EnumTrait<UnityEngine.PlayMode>.IntToEnum));
		L.RegFunction("CompareTo", new LuaCSFunction(EnumTrait<UnityEngine.PlayMode>.CompareTo));
		L.RegFunction("ToString", new LuaCSFunction(EnumTrait<UnityEngine.PlayMode>.ToString));
#if !LUAC_5_3
		L.RegEnumEqualFunction("__eq");
#endif
		L.RegFunction("Equals", new LuaCSFunction(EnumTrait<UnityEngine.PlayMode>.Equals));
		L.RegFunction("__tostring", new LuaCSFunction(EnumTrait<UnityEngine.PlayMode>.ToString));
		L.EndEnum();
		TypeTraits<UnityEngine.PlayMode>.Check = EnumTrait<UnityEngine.PlayMode>.CheckType;
		StackTraits<UnityEngine.PlayMode>.Push = ToLua.PushData<UnityEngine.PlayMode>;
		EnumTrait<UnityEngine.PlayMode>.IntToEnumTransfer = (i) => (UnityEngine.PlayMode)i;
		EnumTrait<UnityEngine.PlayMode>.EnumToInt = (e) => (int)e;
	}


	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StopSameLayer(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.PlayMode.StopSameLayer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StopAll(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.PlayMode.StopAll);
		return 1;
	}
}

