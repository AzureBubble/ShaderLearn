Shader "Lesson/Lesson44_BlinnPhong"
{
    Properties
    {
        _MainColor ("MainColor", Color) = (1,1,1,1)
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

            struct v2f
            {
                float4 pos : SV_POSITION;
                fixed3 color : COLOR;
            };

            fixed4 _MainColor;
            fixed4 _SpecularColor;
            float _SpecularNum;

            fixed3 GetLambertColor(float3 wNormal)
            {
                // 光照方向
                float3 lightDir = normalize(_WorldSpaceLightPos0);
                // 法线
                float3 normal = UnityObjectToWorldNormal(wNormal);

                fixed3 color = _LightColor0 * _MainColor * max(0, dot(normal, lightDir));
                return color;
            }

             fixed3 GetBlinnPhongColor(float3 vertex, float3 wNormal)
            {
                // 光照方向
                float3 lightDir = normalize(_WorldSpaceLightPos0);
                // 法线
                float3 normal = UnityObjectToWorldNormal(wNormal);
                // 世界空间的顶点坐标
                float3 wPos = mul(unity_ObjectToWorld, vertex);
                // 视角方向
                float3 viewDir = normalize(_WorldSpaceCameraPos - wPos);
                // 半角方向向量
                float3 halfADir = normalize(viewDir + lightDir);

                fixed3 color = _LightColor0 * _SpecularColor * pow(max(0, dot(normal, halfADir)), _SpecularNum);
                return color;
            }

            v2f vert (appdata_base v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                fixed3 lambertColor = GetLambertColor(v.normal);
                fixed3 blinnPhongColor = GetBlinnPhongColor(v.vertex, v.normal);
                // Blinn-Phong光照模型 = 环境光 + 兰伯特光照模型 + blinnPhong高光反射模型
                fixed3 color = UNITY_LIGHTMODEL_AMBIENT.rgb + lambertColor + blinnPhongColor;
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