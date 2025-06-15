Shader "Lesson/Lesson41_BlinnPhongSpecular"
{
    Properties
    {
        _SpecularColor ("SpecularColor", Color) = (1,1,1,1)
        _SpecularNum ("SpecularNum", Range(0, 20)) = 5
    }
    SubShader
    {
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
                fixed3 color : COLOR;
            };

            v2f vert (appdata_base v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);

                // 光照方向
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                // 世界坐标下顶点坐标
                float3 worldPos = mul(unity_ObjectToWorld, v.vertex);
                // 视角方向
                float3 viewDir = normalize(_WorldSpaceCameraPos.xyz - worldPos);
                // 半角方向向量
                float3 halfAngleDir = normalize(viewDir + lightDir);

                float3 normal = UnityObjectToWorldNormal(v.normal);

                // Blinn-Phong高光反射模型 = 光照颜色 * 材质高光反射颜色 * pow(max(0, dot(标准化半角向量方向向量, 标准化顶点法线向量)), 光泽度)
                fixed3 color = _LightColor0.rgb * _SpecularColor.rgb * pow(max(0, dot(halfAngleDir, normal)), _SpecularNum);
                o.color = color;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                return fixed4(i.color.rgb, 1);
            }
            ENDCG
        }
    }
}