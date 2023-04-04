﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_TransformWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Transform), typeof(UnityEngine.Component));
		L.RegFunction("SetParent", new LuaCSFunction(SetParent));
		L.RegFunction("SetPositionAndRotation", new LuaCSFunction(SetPositionAndRotation));
		L.RegFunction("Translate", new LuaCSFunction(Translate));
		L.RegFunction("Rotate", new LuaCSFunction(Rotate));
		L.RegFunction("RotateAround", new LuaCSFunction(RotateAround));
		L.RegFunction("LookAt", new LuaCSFunction(LookAt));
		L.RegFunction("TransformDirection", new LuaCSFunction(TransformDirection));
		L.RegFunction("InverseTransformDirection", new LuaCSFunction(InverseTransformDirection));
		L.RegFunction("TransformVector", new LuaCSFunction(TransformVector));
		L.RegFunction("InverseTransformVector", new LuaCSFunction(InverseTransformVector));
		L.RegFunction("TransformPoint", new LuaCSFunction(TransformPoint));
		L.RegFunction("InverseTransformPoint", new LuaCSFunction(InverseTransformPoint));
		L.RegFunction("DetachChildren", new LuaCSFunction(DetachChildren));
		L.RegFunction("SetAsFirstSibling", new LuaCSFunction(SetAsFirstSibling));
		L.RegFunction("SetAsLastSibling", new LuaCSFunction(SetAsLastSibling));
		L.RegFunction("SetSiblingIndex", new LuaCSFunction(SetSiblingIndex));
		L.RegFunction("GetSiblingIndex", new LuaCSFunction(GetSiblingIndex));
		L.RegFunction("Find", new LuaCSFunction(Find));
		L.RegFunction("IsChildOf", new LuaCSFunction(IsChildOf));
		L.RegFunction("GetEnumerator", new LuaCSFunction(GetEnumerator));
		L.RegFunction("GetChild", new LuaCSFunction(GetChild));
		L.RegFunction("__eq", new LuaCSFunction(op_Equality));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("position", new LuaCSFunction(get_position), new LuaCSFunction(set_position));
		L.RegVar("localPosition", new LuaCSFunction(get_localPosition), new LuaCSFunction(set_localPosition));
		L.RegVar("eulerAngles", new LuaCSFunction(get_eulerAngles), new LuaCSFunction(set_eulerAngles));
		L.RegVar("localEulerAngles", new LuaCSFunction(get_localEulerAngles), new LuaCSFunction(set_localEulerAngles));
		L.RegVar("right", new LuaCSFunction(get_right), new LuaCSFunction(set_right));
		L.RegVar("up", new LuaCSFunction(get_up), new LuaCSFunction(set_up));
		L.RegVar("forward", new LuaCSFunction(get_forward), new LuaCSFunction(set_forward));
		L.RegVar("rotation", new LuaCSFunction(get_rotation), new LuaCSFunction(set_rotation));
		L.RegVar("localRotation", new LuaCSFunction(get_localRotation), new LuaCSFunction(set_localRotation));
		L.RegVar("localScale", new LuaCSFunction(get_localScale), new LuaCSFunction(set_localScale));
		L.RegVar("parent", new LuaCSFunction(get_parent), new LuaCSFunction(set_parent));
		L.RegVar("worldToLocalMatrix", new LuaCSFunction(get_worldToLocalMatrix), null);
		L.RegVar("localToWorldMatrix", new LuaCSFunction(get_localToWorldMatrix), null);
		L.RegVar("root", new LuaCSFunction(get_root), null);
		L.RegVar("childCount", new LuaCSFunction(get_childCount), null);
		L.RegVar("lossyScale", new LuaCSFunction(get_lossyScale), null);
		L.RegVar("hasChanged", new LuaCSFunction(get_hasChanged), new LuaCSFunction(set_hasChanged));
		L.RegVar("hierarchyCapacity", new LuaCSFunction(get_hierarchyCapacity), new LuaCSFunction(set_hierarchyCapacity));
		L.RegVar("hierarchyCount", new LuaCSFunction(get_hierarchyCount), null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetParent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Transform arg0 = ToLua.CheckObject<UnityEngine.Transform>(L, 2);
				obj.SetParent(arg0);
				return 0;
			}
			else if (count == 3)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Transform arg0 = ToLua.CheckObject<UnityEngine.Transform>(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.SetParent(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.SetParent");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPositionAndRotation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Quaternion arg1 = ToLua.ToQuaternion(L, 3);
			obj.SetPositionAndRotation(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Translate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				obj.Translate(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.Space>(L, 3))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Space arg1 = StackTraits<UnityEngine.Space>.To(L, 3);
				obj.Translate(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.Transform>(L, 3))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.ToObject(L, 3);
				obj.Translate(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				obj.Translate(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes<UnityEngine.Space>(L, 5))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Space arg3 = StackTraits<UnityEngine.Space>.To(L, 5);
				obj.Translate(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes<UnityEngine.Transform>(L, 5))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Transform arg3 = (UnityEngine.Transform)ToLua.ToObject(L, 5);
				obj.Translate(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.Translate");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rotate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				obj.Rotate(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<float>(L, 3))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				obj.Rotate(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.Space>(L, 3))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Space arg1 = StackTraits<UnityEngine.Space>.To(L, 3);
				obj.Rotate(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<float, float, float>(L, 2))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.lua_tonumber(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				float arg2 = (float)LuaDLL.lua_tonumber(L, 4);
				obj.Rotate(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<UnityEngine.Vector3, float, UnityEngine.Space>(L, 2))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				UnityEngine.Space arg2 = StackTraits<UnityEngine.Space>.To(L, 4);
				obj.Rotate(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Space arg3 = StackTraits<UnityEngine.Space>.Check(L, 5);
				obj.Rotate(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.Rotate");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RotateAround(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			obj.RotateAround(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LookAt(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Transform>(L, 2))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
				obj.LookAt(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Vector3>(L, 2))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				obj.LookAt(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.Transform, UnityEngine.Vector3>(L, 2))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				obj.LookAt(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>(L, 2))
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				obj.LookAt(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.LookAt");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransformDirection(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.TransformDirection(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Vector3 o = obj.TransformDirection(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.TransformDirection");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InverseTransformDirection(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.InverseTransformDirection(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Vector3 o = obj.InverseTransformDirection(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.InverseTransformDirection");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransformVector(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.TransformVector(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Vector3 o = obj.TransformVector(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.TransformVector");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InverseTransformVector(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.InverseTransformVector(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Vector3 o = obj.InverseTransformVector(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.InverseTransformVector");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransformPoint(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.TransformPoint(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Vector3 o = obj.TransformPoint(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.TransformPoint");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InverseTransformPoint(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.InverseTransformPoint(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4)
			{
				UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Vector3 o = obj.InverseTransformPoint(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Transform.InverseTransformPoint");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DetachChildren(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			obj.DetachChildren();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAsFirstSibling(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			obj.SetAsFirstSibling();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAsLastSibling(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			obj.SetAsLastSibling();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetSiblingIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			obj.SetSiblingIndex(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSiblingIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			int o = obj.GetSiblingIndex();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Find(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Transform o = obj.Find(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsChildOf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			UnityEngine.Transform arg0 = ToLua.CheckObject<UnityEngine.Transform>(L, 2);
			bool o = obj.IsChildOf(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumerator(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			System.Collections.IEnumerator o = obj.GetEnumerator();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Transform obj = ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.Transform o = obj.GetChild(arg0);
			ToLua.Push(L, o);
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
	static int get_position(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 ret = obj.position;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localPosition(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 ret = obj.localPosition;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localPosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_eulerAngles(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 ret = obj.eulerAngles;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index eulerAngles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localEulerAngles(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 ret = obj.localEulerAngles;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localEulerAngles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_right(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 ret = obj.right;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index right on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_up(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 ret = obj.up;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index up on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forward(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 ret = obj.forward;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index forward on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotation(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Quaternion ret = obj.rotation;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index rotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localRotation(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Quaternion ret = obj.localRotation;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localRotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localScale(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 ret = obj.localScale;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_parent(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Transform ret = obj.parent;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index parent on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldToLocalMatrix(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 ret = obj.worldToLocalMatrix;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index worldToLocalMatrix on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localToWorldMatrix(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 ret = obj.localToWorldMatrix;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localToWorldMatrix on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_root(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Transform ret = obj.root;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index root on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_childCount(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			int ret = obj.childCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index childCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lossyScale(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 ret = obj.lossyScale;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index lossyScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasChanged(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			bool ret = obj.hasChanged;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index hasChanged on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hierarchyCapacity(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			int ret = obj.hierarchyCapacity;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index hierarchyCapacity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hierarchyCount(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			int ret = obj.hierarchyCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index hierarchyCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_position(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.position = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localPosition(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.localPosition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localPosition on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_eulerAngles(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.eulerAngles = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index eulerAngles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localEulerAngles(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.localEulerAngles = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localEulerAngles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_right(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.right = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index right on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_up(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.up = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index up on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forward(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.forward = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index forward on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rotation(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Quaternion arg0 = ToLua.ToQuaternion(L, 2);
			obj.rotation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index rotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localRotation(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Quaternion arg0 = ToLua.ToQuaternion(L, 2);
			obj.localRotation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localRotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localScale(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.localScale = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_parent(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UnityEngine.Transform arg0 = ToLua.CheckObject<UnityEngine.Transform>(L, 2);
			obj.parent = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index parent on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hasChanged(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.hasChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index hasChanged on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hierarchyCapacity(IntPtr L)
	{
		UnityEngine.Transform obj = null;
		try
		{
			obj = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			obj.hierarchyCapacity = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index hierarchyCapacity on a nil value");
		}
	}
}

