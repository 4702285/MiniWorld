﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_QueueModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.QueueMode));
		L.RegVar("CompleteOthers", new LuaCSFunction(get_CompleteOthers), null);
		L.RegVar("PlayNow", new LuaCSFunction(get_PlayNow), null);
		L.RegFunction("ToInt", new LuaCSFunction(EnumTrait<UnityEngine.QueueMode>.ToInt));
		L.RegFunction("IntToEnum", new LuaCSFunction(EnumTrait<UnityEngine.QueueMode>.IntToEnum));
		L.RegFunction("CompareTo", new LuaCSFunction(EnumTrait<UnityEngine.QueueMode>.CompareTo));
		L.RegFunction("ToString", new LuaCSFunction(EnumTrait<UnityEngine.QueueMode>.ToString));
#if !LUAC_5_3
		L.RegEnumEqualFunction("__eq");
#endif
		L.RegFunction("Equals", new LuaCSFunction(EnumTrait<UnityEngine.QueueMode>.Equals));
		L.RegFunction("__tostring", new LuaCSFunction(EnumTrait<UnityEngine.QueueMode>.ToString));
		L.EndEnum();
		TypeTraits<UnityEngine.QueueMode>.Check = EnumTrait<UnityEngine.QueueMode>.CheckType;
		StackTraits<UnityEngine.QueueMode>.Push = ToLua.PushData<UnityEngine.QueueMode>;
		EnumTrait<UnityEngine.QueueMode>.IntToEnumTransfer = (i) => (UnityEngine.QueueMode)i;
		EnumTrait<UnityEngine.QueueMode>.EnumToInt = (e) => (int)e;
	}


	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CompleteOthers(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.QueueMode.CompleteOthers);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PlayNow(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.QueueMode.PlayNow);
		return 1;
	}
}
