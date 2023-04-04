Shader "Meta/ColorMeta"
{
    Properties
    {
        _Gloss ("Smoothness", Range(0,1)) = 0.5
    }
    SubShader
    {
        Pass
        {
            Tags {"LightMode" = "ForwardBase"}
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "Lighting.cginc"

            float _Gloss;

            struct app_data
            {
                float4 vertex : POSITION;
                fixed4 color : COLOR;
                float3 normal : NORMAL;
            };
            struct f_data
            {
                float4 pos : SV_POSITION;
                float3 n : TEXCOORD0;
                fixed4 color : TEXCOORD1;
            };

            f_data vert(app_data v)
            {
                f_data o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.n = mul(v.normal, (float3x3)unity_ObjectToWorld);
                o.color = v.color;
                return o;
            };

            fixed4 frag(f_data i) : SV_Target
            {
                float3 n = normalize(i.n);
                fixed3 l = normalize(_WorldSpaceLightPos0.xyz);
                fixed3 diffuse = _LightColor0.rgb * saturate(dot(n,l)) * i.color.rgb;
                return fixed4(diffuse, i.color.a);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
