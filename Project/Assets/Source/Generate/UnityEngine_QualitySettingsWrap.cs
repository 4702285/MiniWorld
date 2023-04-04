﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_QualitySettingsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("QualitySettings");
		L.RegFunction("IncreaseLevel", new LuaCSFunction(IncreaseLevel));
		L.RegFunction("DecreaseLevel", new LuaCSFunction(DecreaseLevel));
		L.RegFunction("SetQualityLevel", new LuaCSFunction(SetQualityLevel));
		L.RegFunction("GetRenderPipelineAssetAt", new LuaCSFunction(GetRenderPipelineAssetAt));
		L.RegFunction("GetQualityLevel", new LuaCSFunction(GetQualityLevel));
		L.RegFunction("__eq", new LuaCSFunction(op_Equality));
		L.RegVar("pixelLightCount", new LuaCSFunction(get_pixelLightCount), new LuaCSFunction(set_pixelLightCount));
		L.RegVar("shadows", new LuaCSFunction(get_shadows), new LuaCSFunction(set_shadows));
		L.RegVar("shadowProjection", new LuaCSFunction(get_shadowProjection), new LuaCSFunction(set_shadowProjection));
		L.RegVar("shadowCascades", new LuaCSFunction(get_shadowCascades), new LuaCSFunction(set_shadowCascades));
		L.RegVar("shadowDistance", new LuaCSFunction(get_shadowDistance), new LuaCSFunction(set_shadowDistance));
		L.RegVar("shadowResolution", new LuaCSFunction(get_shadowResolution), new LuaCSFunction(set_shadowResolution));
		L.RegVar("shadowmaskMode", new LuaCSFunction(get_shadowmaskMode), new LuaCSFunction(set_shadowmaskMode));
		L.RegVar("shadowNearPlaneOffset", new LuaCSFunction(get_shadowNearPlaneOffset), new LuaCSFunction(set_shadowNearPlaneOffset));
		L.RegVar("shadowCascade2Split", new LuaCSFunction(get_shadowCascade2Split), new LuaCSFunction(set_shadowCascade2Split));
		L.RegVar("shadowCascade4Split", new LuaCSFunction(get_shadowCascade4Split), new LuaCSFunction(set_shadowCascade4Split));
		L.RegVar("lodBias", new LuaCSFunction(get_lodBias), new LuaCSFunction(set_lodBias));
		L.RegVar("anisotropicFiltering", new LuaCSFunction(get_anisotropicFiltering), new LuaCSFunction(set_anisotropicFiltering));
		L.RegVar("masterTextureLimit", new LuaCSFunction(get_masterTextureLimit), new LuaCSFunction(set_masterTextureLimit));
		L.RegVar("maximumLODLevel", new LuaCSFunction(get_maximumLODLevel), new LuaCSFunction(set_maximumLODLevel));
		L.RegVar("particleRaycastBudget", new LuaCSFunction(get_particleRaycastBudget), new LuaCSFunction(set_particleRaycastBudget));
		L.RegVar("softParticles", new LuaCSFunction(get_softParticles), new LuaCSFunction(set_softParticles));
		L.RegVar("softVegetation", new LuaCSFunction(get_softVegetation), new LuaCSFunction(set_softVegetation));
		L.RegVar("vSyncCount", new LuaCSFunction(get_vSyncCount), new LuaCSFunction(set_vSyncCount));
		L.RegVar("antiAliasing", new LuaCSFunction(get_antiAliasing), new LuaCSFunction(set_antiAliasing));
		L.RegVar("asyncUploadTimeSlice", new LuaCSFunction(get_asyncUploadTimeSlice), new LuaCSFunction(set_asyncUploadTimeSlice));
		L.RegVar("asyncUploadBufferSize", new LuaCSFunction(get_asyncUploadBufferSize), new LuaCSFunction(set_asyncUploadBufferSize));
		L.RegVar("asyncUploadPersistentBuffer", new LuaCSFunction(get_asyncUploadPersistentBuffer), new LuaCSFunction(set_asyncUploadPersistentBuffer));
		L.RegVar("realtimeReflectionProbes", new LuaCSFunction(get_realtimeReflectionProbes), new LuaCSFunction(set_realtimeReflectionProbes));
		L.RegVar("billboardsFaceCameraPosition", new LuaCSFunction(get_billboardsFaceCameraPosition), new LuaCSFunction(set_billboardsFaceCameraPosition));
		L.RegVar("resolutionScalingFixedDPIFactor", new LuaCSFunction(get_resolutionScalingFixedDPIFactor), new LuaCSFunction(set_resolutionScalingFixedDPIFactor));
		L.RegVar("renderPipeline", new LuaCSFunction(get_renderPipeline), new LuaCSFunction(set_renderPipeline));
		L.RegVar("skinWeights", new LuaCSFunction(get_skinWeights), new LuaCSFunction(set_skinWeights));
		L.RegVar("streamingMipmapsActive", new LuaCSFunction(get_streamingMipmapsActive), new LuaCSFunction(set_streamingMipmapsActive));
		L.RegVar("streamingMipmapsMemoryBudget", new LuaCSFunction(get_streamingMipmapsMemoryBudget), new LuaCSFunction(set_streamingMipmapsMemoryBudget));
		L.RegVar("streamingMipmapsAddAllCameras", new LuaCSFunction(get_streamingMipmapsAddAllCameras), new LuaCSFunction(set_streamingMipmapsAddAllCameras));
		L.RegVar("streamingMipmapsMaxFileIORequests", new LuaCSFunction(get_streamingMipmapsMaxFileIORequests), new LuaCSFunction(set_streamingMipmapsMaxFileIORequests));
		L.RegVar("maxQueuedFrames", new LuaCSFunction(get_maxQueuedFrames), new LuaCSFunction(set_maxQueuedFrames));
		L.RegVar("names", new LuaCSFunction(get_names), null);
		L.RegVar("desiredColorSpace", new LuaCSFunction(get_desiredColorSpace), null);
		L.RegVar("activeColorSpace", new LuaCSFunction(get_activeColorSpace), null);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IncreaseLevel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.QualitySettings.IncreaseLevel();
				return 0;
			}
			else if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				UnityEngine.QualitySettings.IncreaseLevel(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.IncreaseLevel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DecreaseLevel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.QualitySettings.DecreaseLevel();
				return 0;
			}
			else if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				UnityEngine.QualitySettings.DecreaseLevel(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.DecreaseLevel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetQualityLevel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 1);
				UnityEngine.QualitySettings.SetQualityLevel(arg0);
				return 0;
			}
			else if (count == 2)
			{
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				UnityEngine.QualitySettings.SetQualityLevel(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.QualitySettings.SetQualityLevel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRenderPipelineAssetAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 1);
			UnityEngine.Rendering.RenderPipelineAsset o = UnityEngine.QualitySettings.GetRenderPipelineAssetAt(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetQualityLevel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			int o = UnityEngine.QualitySettings.GetQualityLevel();
			LuaDLL.lua_pushinteger(L, o);
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
	static int get_pixelLightCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.pixelLightCount);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadows(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.QualitySettings.shadows);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowProjection(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.QualitySettings.shadowProjection);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCascades(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.shadowCascades);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowDistance(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.shadowDistance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowResolution(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.QualitySettings.shadowResolution);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowmaskMode(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.QualitySettings.shadowmaskMode);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowNearPlaneOffset(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.shadowNearPlaneOffset);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCascade2Split(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.shadowCascade2Split);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowCascade4Split(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.shadowCascade4Split);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lodBias(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.lodBias);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anisotropicFiltering(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.QualitySettings.anisotropicFiltering);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_masterTextureLimit(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.masterTextureLimit);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maximumLODLevel(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.maximumLODLevel);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_particleRaycastBudget(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.particleRaycastBudget);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_softParticles(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.softParticles);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_softVegetation(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.softVegetation);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_vSyncCount(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.vSyncCount);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_antiAliasing(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.antiAliasing);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asyncUploadTimeSlice(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.asyncUploadTimeSlice);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asyncUploadBufferSize(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.asyncUploadBufferSize);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asyncUploadPersistentBuffer(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.asyncUploadPersistentBuffer);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_realtimeReflectionProbes(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.realtimeReflectionProbes);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_billboardsFaceCameraPosition(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.billboardsFaceCameraPosition);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resolutionScalingFixedDPIFactor(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderPipeline(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.renderPipeline);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_skinWeights(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.QualitySettings.skinWeights);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingMipmapsActive(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.streamingMipmapsActive);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingMipmapsMemoryBudget(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.QualitySettings.streamingMipmapsMemoryBudget);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingMipmapsAddAllCameras(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.QualitySettings.streamingMipmapsAddAllCameras);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingMipmapsMaxFileIORequests(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxQueuedFrames(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.QualitySettings.maxQueuedFrames);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_names(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.QualitySettings.names);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_desiredColorSpace(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.QualitySettings.desiredColorSpace);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_activeColorSpace(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.QualitySettings.activeColorSpace);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pixelLightCount(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.pixelLightCount = arg0;
			UnityEngine.QualitySettings.pixelLightCount = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadows(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowQuality arg0 = StackTraits<UnityEngine.ShadowQuality>.Check(L, 2);
			UnityEngine.QualitySettings.shadows = arg0;
			UnityEngine.QualitySettings.shadows = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowProjection(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowProjection arg0 = StackTraits<UnityEngine.ShadowProjection>.Check(L, 2);
			UnityEngine.QualitySettings.shadowProjection = arg0;
			UnityEngine.QualitySettings.shadowProjection = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascades(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.shadowCascades = arg0;
			UnityEngine.QualitySettings.shadowCascades = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowDistance(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowDistance = arg0;
			UnityEngine.QualitySettings.shadowDistance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowResolution(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowResolution arg0 = StackTraits<UnityEngine.ShadowResolution>.Check(L, 2);
			UnityEngine.QualitySettings.shadowResolution = arg0;
			UnityEngine.QualitySettings.shadowResolution = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowmaskMode(IntPtr L)
	{
		try
		{
			UnityEngine.ShadowmaskMode arg0 = StackTraits<UnityEngine.ShadowmaskMode>.Check(L, 2);
			UnityEngine.QualitySettings.shadowmaskMode = arg0;
			UnityEngine.QualitySettings.shadowmaskMode = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowNearPlaneOffset(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowNearPlaneOffset = arg0;
			UnityEngine.QualitySettings.shadowNearPlaneOffset = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascade2Split(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.shadowCascade2Split = arg0;
			UnityEngine.QualitySettings.shadowCascade2Split = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowCascade4Split(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.QualitySettings.shadowCascade4Split = arg0;
			UnityEngine.QualitySettings.shadowCascade4Split = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lodBias(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.lodBias = arg0;
			UnityEngine.QualitySettings.lodBias = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anisotropicFiltering(IntPtr L)
	{
		try
		{
			UnityEngine.AnisotropicFiltering arg0 = StackTraits<UnityEngine.AnisotropicFiltering>.Check(L, 2);
			UnityEngine.QualitySettings.anisotropicFiltering = arg0;
			UnityEngine.QualitySettings.anisotropicFiltering = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_masterTextureLimit(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.masterTextureLimit = arg0;
			UnityEngine.QualitySettings.masterTextureLimit = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumLODLevel(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.maximumLODLevel = arg0;
			UnityEngine.QualitySettings.maximumLODLevel = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_particleRaycastBudget(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.particleRaycastBudget = arg0;
			UnityEngine.QualitySettings.particleRaycastBudget = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_softParticles(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.softParticles = arg0;
			UnityEngine.QualitySettings.softParticles = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_softVegetation(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.softVegetation = arg0;
			UnityEngine.QualitySettings.softVegetation = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_vSyncCount(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.vSyncCount = arg0;
			UnityEngine.QualitySettings.vSyncCount = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_antiAliasing(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.antiAliasing = arg0;
			UnityEngine.QualitySettings.antiAliasing = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asyncUploadTimeSlice(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.asyncUploadTimeSlice = arg0;
			UnityEngine.QualitySettings.asyncUploadTimeSlice = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asyncUploadBufferSize(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.asyncUploadBufferSize = arg0;
			UnityEngine.QualitySettings.asyncUploadBufferSize = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_asyncUploadPersistentBuffer(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.asyncUploadPersistentBuffer = arg0;
			UnityEngine.QualitySettings.asyncUploadPersistentBuffer = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_realtimeReflectionProbes(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.realtimeReflectionProbes = arg0;
			UnityEngine.QualitySettings.realtimeReflectionProbes = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_billboardsFaceCameraPosition(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.billboardsFaceCameraPosition = arg0;
			UnityEngine.QualitySettings.billboardsFaceCameraPosition = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resolutionScalingFixedDPIFactor(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor = arg0;
			UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderPipeline(IntPtr L)
	{
		try
		{
			UnityEngine.Rendering.RenderPipelineAsset arg0 = ToLua.CheckObject<UnityEngine.Rendering.RenderPipelineAsset>(L, 2);
			UnityEngine.QualitySettings.renderPipeline = arg0;
			UnityEngine.QualitySettings.renderPipeline = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_skinWeights(IntPtr L)
	{
		try
		{
			UnityEngine.SkinWeights arg0 = StackTraits<UnityEngine.SkinWeights>.Check(L, 2);
			UnityEngine.QualitySettings.skinWeights = arg0;
			UnityEngine.QualitySettings.skinWeights = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_streamingMipmapsActive(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.streamingMipmapsActive = arg0;
			UnityEngine.QualitySettings.streamingMipmapsActive = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_streamingMipmapsMemoryBudget(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.QualitySettings.streamingMipmapsMemoryBudget = arg0;
			UnityEngine.QualitySettings.streamingMipmapsMemoryBudget = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_streamingMipmapsAddAllCameras(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.QualitySettings.streamingMipmapsAddAllCameras = arg0;
			UnityEngine.QualitySettings.streamingMipmapsAddAllCameras = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_streamingMipmapsMaxFileIORequests(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests = arg0;
			UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxQueuedFrames(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			UnityEngine.QualitySettings.maxQueuedFrames = arg0;
			UnityEngine.QualitySettings.maxQueuedFrames = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

