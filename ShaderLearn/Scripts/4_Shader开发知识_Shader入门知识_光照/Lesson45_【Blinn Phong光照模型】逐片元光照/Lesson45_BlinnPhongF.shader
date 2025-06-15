Shader "Lesson/Lesson45_BlinnPhongF"
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
                float3 wNormal : NORMAL;
                float3 wPos : TEXCOORD0;
            };

            fixed4 _MainColor;
            fixed4 _SpecularColor;
            float _SpecularNum;


            v2f vert (appdata_base v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.wNormal = UnityObjectToWorldNormal(v.normal);
                o.wPos = mul(unity_ObjectToWorld, v.vertex);
                return o;
            }

            fixed3 GetLambertColor(float3 normal)
            {
                float3 lightDir = normalize(_WorldSpaceLightPos0);
                fixed3 color = _LightColor0 * _MainColor * max(0, dot(lightDir, normal));
                return color;
            }

            fixed3 GetBlinnPhongColor(float3 wPos, float3 normal)
            {
                float3 lightDir = normalize(_WorldSpaceLightPos0);
                float3 viewDir = normalize(_WorldSpaceCameraPos - wPos);
                float3 halfADir = normalize(viewDir + lightDir);

                fixed3 color = _LightColor0 * _SpecularColor * pow(max(0, dot(normal, halfADir)), _SpecularNum) ;
                return color;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed3 lambertColor = GetLambertColor(i.wNormal);
                fixed3 blinnPhongColor = GetBlinnPhongColor(i.wPos, i.wNormal);
                // Blinn-Phong光照模型 = 环境光 + 兰伯特光照模型 + blinnPhong高光反射模型
                fixed3 color = UNITY_LIGHTMODEL_AMBIENT.rgb + lambertColor + blinnPhongColor;
                return fixed4(color, 1);
            }
            ENDCG
        }
    }
}