﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_AnimationBlendModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.AnimationBlendMode));
		L.RegVar("Blend", new LuaCSFunction(get_Blend), null);
		L.RegVar("Additive", new LuaCSFunction(get_Additive), null);
		L.RegFunction("ToInt", new LuaCSFunction(EnumTrait<UnityEngine.AnimationBlendMode>.ToInt));
		L.RegFunction("IntToEnum", new LuaCSFunction(EnumTrait<UnityEngine.AnimationBlendMode>.IntToEnum));
		L.RegFunction("CompareTo", new LuaCSFunction(EnumTrait<UnityEngine.AnimationBlendMode>.CompareTo));
		L.RegFunction("ToString", new LuaCSFunction(EnumTrait<UnityEngine.AnimationBlendMode>.ToString));
#if !LUAC_5_3
		L.RegEnumEqualFunction("__eq");
#endif
		L.RegFunction("Equals", new LuaCSFunction(EnumTrait<UnityEngine.AnimationBlendMode>.Equals));
		L.RegFunction("__tostring", new LuaCSFunction(EnumTrait<UnityEngine.AnimationBlendMode>.ToString));
		L.EndEnum();
		TypeTraits<UnityEngine.AnimationBlendMode>.Check = EnumTrait<UnityEngine.AnimationBlendMode>.CheckType;
		StackTraits<UnityEngine.AnimationBlendMode>.Push = ToLua.PushData<UnityEngine.AnimationBlendMode>;
		EnumTrait<UnityEngine.AnimationBlendMode>.IntToEnumTransfer = (i) => (UnityEngine.AnimationBlendMode)i;
		EnumTrait<UnityEngine.AnimationBlendMode>.EnumToInt = (e) => (int)e;
	}


	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Blend(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.AnimationBlendMode.Blend);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Additive(IntPtr L)
	{
		ToLua.PushData(L, UnityEngine.AnimationBlendMode.Additive);
		return 1;
	}
}

