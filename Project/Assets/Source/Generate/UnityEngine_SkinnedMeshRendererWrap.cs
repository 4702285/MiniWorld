﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_SkinnedMeshRendererWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.SkinnedMeshRenderer), typeof(UnityEngine.Renderer));
		L.RegFunction("GetBlendShapeWeight", new LuaCSFunction(GetBlendShapeWeight));
		L.RegFunction("SetBlendShapeWeight", new LuaCSFunction(SetBlendShapeWeight));
		L.RegFunction("BakeMesh", new LuaCSFunction(BakeMesh));
		L.RegFunction("New", new LuaCSFunction(_CreateUnityEngine_SkinnedMeshRenderer));
		L.RegFunction("__eq", new LuaCSFunction(op_Equality));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("quality", new LuaCSFunction(get_quality), new LuaCSFunction(set_quality));
		L.RegVar("updateWhenOffscreen", new LuaCSFunction(get_updateWhenOffscreen), new LuaCSFunction(set_updateWhenOffscreen));
		L.RegVar("forceMatrixRecalculationPerRender", new LuaCSFunction(get_forceMatrixRecalculationPerRender), new LuaCSFunction(set_forceMatrixRecalculationPerRender));
		L.RegVar("rootBone", new LuaCSFunction(get_rootBone), new LuaCSFunction(set_rootBone));
		L.RegVar("bones", new LuaCSFunction(get_bones), new LuaCSFunction(set_bones));
		L.RegVar("sharedMesh", new LuaCSFunction(get_sharedMesh), new LuaCSFunction(set_sharedMesh));
		L.RegVar("skinnedMotionVectors", new LuaCSFunction(get_skinnedMotionVectors), new LuaCSFunction(set_skinnedMotionVectors));
		L.RegVar("localBounds", new LuaCSFunction(get_localBounds), new LuaCSFunction(set_localBounds));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_SkinnedMeshRenderer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.SkinnedMeshRenderer obj = new UnityEngine.SkinnedMeshRenderer();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.SkinnedMeshRenderer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBlendShapeWeight(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.SkinnedMeshRenderer obj = ToLua.CheckObject<UnityEngine.SkinnedMeshRenderer>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			float o = obj.GetBlendShapeWeight(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetBlendShapeWeight(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.SkinnedMeshRenderer obj = ToLua.CheckObject<UnityEngine.SkinnedMeshRenderer>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.SetBlendShapeWeight(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BakeMesh(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.SkinnedMeshRenderer obj = ToLua.CheckObject<UnityEngine.SkinnedMeshRenderer>(L, 1);
				UnityEngine.Mesh arg0 = ToLua.CheckObject<UnityEngine.Mesh>(L, 2);
				obj.BakeMesh(arg0);
				return 0;
			}
			else if (count == 3)
			{
				UnityEngine.SkinnedMeshRenderer obj = ToLua.CheckObject<UnityEngine.SkinnedMeshRenderer>(L, 1);
				UnityEngine.Mesh arg0 = ToLua.CheckObject<UnityEngine.Mesh>(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.BakeMesh(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.SkinnedMeshRenderer.BakeMesh");
			}
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
	static int get_quality(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			UnityEngine.SkinQuality ret = obj.quality;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index quality on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateWhenOffscreen(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			bool ret = obj.updateWhenOffscreen;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index updateWhenOffscreen on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forceMatrixRecalculationPerRender(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			bool ret = obj.forceMatrixRecalculationPerRender;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index forceMatrixRecalculationPerRender on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rootBone(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			UnityEngine.Transform ret = obj.rootBone;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index rootBone on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bones(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			UnityEngine.Transform[] ret = obj.bones;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index bones on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sharedMesh(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			UnityEngine.Mesh ret = obj.sharedMesh;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index sharedMesh on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_skinnedMotionVectors(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			bool ret = obj.skinnedMotionVectors;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index skinnedMotionVectors on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localBounds(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			UnityEngine.Bounds ret = obj.localBounds;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localBounds on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_quality(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			UnityEngine.SkinQuality arg0 = StackTraits<UnityEngine.SkinQuality>.Check(L, 2);
			obj.quality = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index quality on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_updateWhenOffscreen(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.updateWhenOffscreen = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index updateWhenOffscreen on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forceMatrixRecalculationPerRender(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.forceMatrixRecalculationPerRender = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index forceMatrixRecalculationPerRender on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rootBone(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			UnityEngine.Transform arg0 = ToLua.CheckObject<UnityEngine.Transform>(L, 2);
			obj.rootBone = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index rootBone on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bones(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			UnityEngine.Transform[] arg0 = ToLua.CheckObjectArray<UnityEngine.Transform>(L, 2);
			obj.bones = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index bones on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sharedMesh(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			UnityEngine.Mesh arg0 = ToLua.CheckObject<UnityEngine.Mesh>(L, 2);
			obj.sharedMesh = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index sharedMesh on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_skinnedMotionVectors(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.skinnedMotionVectors = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index skinnedMotionVectors on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_localBounds(IntPtr L)
	{
		UnityEngine.SkinnedMeshRenderer obj = null;
		try
		{
			obj = (UnityEngine.SkinnedMeshRenderer)ToLua.ToObject(L, 1);
			UnityEngine.Bounds arg0 = ToLua.ToBounds(L, 2);
			obj.localBounds = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, obj, "attempt to index localBounds on a nil value");
		}
	}
}

