﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ScreenWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Screen");
		L.RegFunction("SetResolution", new LuaCSFunction(SetResolution));
		L.RegVar("width", new LuaCSFunction(get_width), null);
		L.RegVar("height", new LuaCSFunction(get_height), null);
		L.RegVar("dpi", new LuaCSFunction(get_dpi), null);
		L.RegVar("currentResolution", new LuaCSFunction(get_currentResolution), null);
		L.RegVar("resolutions", new LuaCSFunction(get_resolutions), null);
		L.RegVar("fullScreen", new LuaCSFunction(get_fullScreen), new LuaCSFunction(set_fullScreen));
		L.RegVar("fullScreenMode", new LuaCSFunction(get_fullScreenMode), new LuaCSFunction(set_fullScreenMode));
		L.RegVar("safeArea", new LuaCSFunction(get_safeArea), null);
		L.RegVar("cutouts", new LuaCSFunction(get_cutouts), null);
		L.RegVar("autorotateToPortrait", new LuaCSFunction(get_autorotateToPortrait), new LuaCSFunction(set_autorotateToPortrait));
		L.RegVar("autorotateToPortraitUpsideDown", new LuaCSFunction(get_autorotateToPortraitUpsideDown), new LuaCSFunction(set_autorotateToPortraitUpsideDown));
		L.RegVar("autorotateToLandscapeLeft", new LuaCSFunction(get_autorotateToLandscapeLeft), new LuaCSFunction(set_autorotateToLandscapeLeft));
		L.RegVar("autorotateToLandscapeRight", new LuaCSFunction(get_autorotateToLandscapeRight), new LuaCSFunction(set_autorotateToLandscapeRight));
		L.RegVar("orientation", new LuaCSFunction(get_orientation), new LuaCSFunction(set_orientation));
		L.RegVar("sleepTimeout", new LuaCSFunction(get_sleepTimeout), new LuaCSFunction(set_sleepTimeout));
		L.RegVar("brightness", new LuaCSFunction(get_brightness), new LuaCSFunction(set_brightness));
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetResolution(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes<bool>(L, 3))
			{
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 1);
				int arg1 = (int)LuaDLL.luaL_checkinteger(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				UnityEngine.Screen.SetResolution(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.FullScreenMode>(L, 3))
			{
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 1);
				int arg1 = (int)LuaDLL.luaL_checkinteger(L, 2);
				UnityEngine.FullScreenMode arg2 = StackTraits<UnityEngine.FullScreenMode>.To(L, 3);
				UnityEngine.Screen.SetResolution(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<bool, int>(L, 3))
			{
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 1);
				int arg1 = (int)LuaDLL.luaL_checkinteger(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				int arg3 = (int)LuaDLL.lua_tointeger(L, 4);
				UnityEngine.Screen.SetResolution(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<UnityEngine.FullScreenMode, int>(L, 3))
			{
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 1);
				int arg1 = (int)LuaDLL.luaL_checkinteger(L, 2);
				UnityEngine.FullScreenMode arg2 = StackTraits<UnityEngine.FullScreenMode>.To(L, 3);
				int arg3 = (int)LuaDLL.lua_tointeger(L, 4);
				UnityEngine.Screen.SetResolution(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Screen.SetResolution");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Screen.width);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Screen.height);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dpi(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Screen.dpi);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentResolution(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.Screen.currentResolution);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resolutions(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Screen.resolutions);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fullScreen(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Screen.fullScreen);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fullScreenMode(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.Screen.fullScreenMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_safeArea(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.Screen.safeArea);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cutouts(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Screen.cutouts);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToPortrait(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Screen.autorotateToPortrait);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToPortraitUpsideDown(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Screen.autorotateToPortraitUpsideDown);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToLandscapeLeft(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Screen.autorotateToLandscapeLeft);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autorotateToLandscapeRight(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Screen.autorotateToLandscapeRight);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_orientation(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.Screen.orientation);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sleepTimeout(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Screen.sleepTimeout);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_brightness(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Screen.brightness);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fullScreen(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.fullScreen = arg0;
			UnityEngine.Screen.fullScreen = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fullScreenMode(IntPtr L)
	{
		try
		{
			UnityEngine.FullScreenMode arg0 = StackTraits<UnityEngine.FullScreenMode>.Check(L, 2);
			UnityEngine.Screen.fullScreenMode = arg0;
			UnityEngine.Screen.fullScreenMode = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToPortrait(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.autorotateToPortrait = arg0;
			UnityEngine.Screen.autorotateToPortrait = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToPortraitUpsideDown(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.autorotateToPortraitUpsideDown = arg0;
			UnityEngine.Screen.autorotateToPortraitUpsideDown = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToLandscapeLeft(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.autorotateToLandscapeLeft = arg0;
			UnityEngine.Screen.autorotateToLandscapeLeft = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autorotateToLandscapeRight(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Screen.autorotateToLandscapeRight = arg0;
			UnityEngine.Screen.autorotateToLandscapeRight = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_orientation(IntPtr L)
	{
		try
		{
			UnityEngine.ScreenOrientation arg0 = StackTraits<UnityEngine.ScreenOrientation>.Check(L, 2);
			UnityEngine.Screen.orientation = arg0;
			UnityEngine.Screen.orientation = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sleepTimeout(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.Screen.sleepTimeout = arg0;
			UnityEngine.Screen.sleepTimeout = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_brightness(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Screen.brightness = arg0;
			UnityEngine.Screen.brightness = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
