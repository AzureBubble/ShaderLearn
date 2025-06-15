Shader "Lesson/Lesson36_SpecularF"
{
    Properties
    {
        _MainColor ("MainColor", Color) = (1,1,1,1)
        _SpecularNum ("SpecularNum", Range(0, 20)) = 0.5
    }
    SubShader
    {
        // 如果有多个Pass渲染通道时 一般情况会把光照模式的 Tags放到对应的Pass中
        // 以免影响其他Pass
        Tags { "LightMode"="ForwardBase" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
            #include "Lighting.cginc"

            fixed4 _MainColor;
            float _SpecularNum;

            struct v2f
            {
                // 裁剪空间的坐标信息
                float4 pos : SV_POSITION;
                // 世界空间的视角方向信息
                float3 wPos : TEXCOORD0;
                // 世界空间下的法线信息
                float3 wNormal : NORMAL;
            };

            v2f vert (appdata_base v)
            {
                v2f o;
                // 模型空间转化到裁剪空间顶点坐标信息
                o.pos = UnityObjectToClipPos(v.vertex);
                // 顶点的世界坐标
                float3 worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
                // 世界坐标下的法线向量
                float3 normal = UnityObjectToWorldNormal(v.normal.xyz);
                o.wNormal = normal;
                o.wPos = worldPos;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // 光照方向
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                // 光照反射向量 = reflect(光照方向, 法线向量);
                float3 reflectDir = reflect(-lightDir, i.wNormal);
                // 视角方向 = 视角坐标 - 顶点坐标
                float3 viewDir = normalize(_WorldSpaceCameraPos.xyz - i.wPos);
                // 高光反射光照颜色 = 光照颜色 * 材质高光反射颜色 * pow(max(0, dot(反射向量, 视角方向向量)), 幂(光泽度))
                fixed3 color = _LightColor0.rgb * _MainColor * pow(max(0, dot(reflectDir, viewDir)), _SpecularNum);
                return fixed4(color.rgb, 1);
            }
            ENDCG
        }
    }
}