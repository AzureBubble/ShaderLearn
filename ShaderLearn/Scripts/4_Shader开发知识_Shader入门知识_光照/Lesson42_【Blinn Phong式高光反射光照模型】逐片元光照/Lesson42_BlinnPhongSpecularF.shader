Shader "Lesson/Lesson42_BlinnPhongSpecularF"
{
    Properties
    {
        _SpecularColor ("SpecularColor", Color) = (1,1,1,1)
        _SpecularNum ("SpecularNum", Range(0, 20)) = 5
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            Tags { "LightMode"="ForwardBase" }
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
            #include "Lighting.cginc"

            fixed4 _SpecularColor;
            float _SpecularNum;

            struct v2f
            {
                float4 pos : SV_POSITION;
                float3 normal : NORMAL;
                float3 wPos : TEXCOORD0;
            };

            v2f vert (appdata_base v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.normal = UnityObjectToWorldNormal(v.normal);
                float3 worldPos = mul(unity_ObjectToWorld, v.vertex);
                o.wPos = worldPos;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // 光照方向
                float3 lightDir = normalize(_WorldSpaceLightPos0);
                // 视角方向
                float3 viewDir = normalize(_WorldSpaceCameraPos - i.wPos);
                float3 halfAngleDir = normalize(viewDir + lightDir);
                // Blinn-Phong高光反射模型 = 光照颜色 * 材质高光反射颜色 * pow(max(0, dot(标准化半角向量方向向量, 标准化顶点法线向量)), 光泽度)
                fixed3 color = _LightColor0 * _SpecularColor * pow(max(0, dot(i.normal, halfAngleDir)), _SpecularNum);
                return fixed4(color, 1);
            }
            ENDCG
        }
    }
}