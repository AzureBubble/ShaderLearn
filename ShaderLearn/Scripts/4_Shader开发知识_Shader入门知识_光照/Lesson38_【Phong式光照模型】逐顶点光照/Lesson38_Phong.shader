Shader "Lesson/Lesson38_Phong"
{
    Properties
    {
        _MainColor ("MainColor", Color) = (1,1,1,1)
        _SpecularColor ("SpecularColor", Color) = (1,1,1,1)
        _SpecularNum ("SpecularNum", Range(0, 20)) = 0.5
    }
    SubShader
    {
        Tags { "LightMode"="ForwardBase" }

        Pass
        {
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
            float _SpecularNum;
            fixed4 _SpecularColor;

            fixed3 GetLambertColor(in float3 objNormal)
            {
                // 法线
                float3 normal = UnityObjectToWorldNormal(objNormal);
                // 光照方向
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                // 兰伯特光照模型
                fixed3 lambertColor = _LightColor0.rgb * _MainColor.rgb * max(0, dot(normal, lightDir));
                return lambertColor;
            }

            fixed3 GetPhongColor(in float3 objNormal, in float4 vertex)
            {
                // 法线
                float3 normal = UnityObjectToWorldNormal(objNormal);
                // 光照方向
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                // Phong高光反射模型颜色
                // 视角向量
                float3 viewDir = normalize(_WorldSpaceCameraPos.xyz - mul(unity_ObjectToWorld, vertex));
                // 反射向量
                float3 reflectDir = reflect(-lightDir, normal);
                fixed3 phongColor = _LightColor0.rgb * _SpecularColor.rgb * pow(max(0, dot(reflectDir, viewDir)), _SpecularNum);
                return phongColor;
            }

            v2f vert (appdata_base v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);

                fixed3 lambertColor = GetLambertColor(v.normal);

                fixed3 phongColor = GetPhongColor(v.normal, v.vertex);
                // Phong光照模型颜色 = 环境光颜色 + 兰伯特光照颜色 + Phong式高光反射颜色
                fixed3 color = UNITY_LIGHTMODEL_AMBIENT.rgb + lambertColor + phongColor;
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