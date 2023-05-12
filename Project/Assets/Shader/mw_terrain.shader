Shader "MiniWorld/Terrain" {
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _BumpMap ("Bump Map", 2D) = "bump" {}
        _Specular ("Specular", Range(0, 1)) = 0.5
        _Shininess ("Shininess", Range(0.01, 1)) = 0.078125
        _CombineHeight ("Combine Height", Range(0, 1)) = 0
        _TerrainSplat ("Terrain Splat", 2DArray) = "" {}
        _SplatCount ("Number of Textures", Range(1, 8)) = 4
    }
 
    SubShader {
        Tags { "Queue"="Geometry-100" }
        LOD 100
 
        CGPROGRAM
        #pragma surface surf Standard
        #pragma require 2darray

        #include "UnityCG.cginc"
 
        sampler2D _MainTex;
        sampler2D _BumpMap;
        float _Specular;
        float _Shininess;
        float _CombineHeight;
        UNITY_DECLARE_TEX2DARRAY(_TerrainSplat);
        int _SplatCount;

        struct Input {
            float2 uv_MainTex;
            float3 worldPos;
            float3 worldNormal;
        };
        
        void surf (Input IN, inout SurfaceOutputStandard o) {
            //获取高度图值,如果有的话
            float height = tex2D(_BumpMap, IN.uv_MainTex).r;
            //将高度的值和_CombineHeight结合
            float combineHeight = lerp(0, 1, step(height, _CombineHeight));

            // 获取地形的颜色，根据高度将多个纹理进行混合
            float3 splat = float3(0, 0, 0);
            for (int i = 0; i < _SplatCount; i++) {
                float4 splatSample = UNITY_SAMPLE_TEX2DARRAY(_TerrainSplat, float3(IN.worldPos.xz, i));
                float weight = splatSample.r * combineHeight;
                splat += splatSample.bgr * weight;
            }

            // 应用基本颜色和高光值
            o.Albedo = splat;
            o.Metallic = 0;
            o.Smoothness = _Shininess;
            //o.Specular = _Specular;
            o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_MainTex));
        }
        ENDCG
    } 
    FallBack "Diffuse"
}