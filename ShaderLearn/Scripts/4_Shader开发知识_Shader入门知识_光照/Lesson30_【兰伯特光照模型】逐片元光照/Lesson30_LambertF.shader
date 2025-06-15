Shader "Lesson/Lesson30_LambertF"
{
    Properties
    {
        // 材质漫反射颜色
        _MainColor ("MainColor", Color) = (1,1,1,1)
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
                float4 pos : SV_POSITION; // 裁剪空间下的顶点坐标信息
                float3 normal: NORMAL; // 世界空间下的顶点法线信息
            };

            fixed4 _MainColor;

            // 顶点着色器主要就是处理顶点、法线、切线等数据的坐标转换
            v2f vert (appdata_base v)
            {
                v2f data;
                // 顶点信息从模型空间转换到裁剪空间
                data.pos = UnityObjectToClipPos(v.vertex);
                // 获得相对于世界空间下的法线信息
                data.normal = UnityObjectToWorldNormal(v.normal);
                return data;
            }

            fixed4 frag (v2f data) : SV_Target
            {
                // 光照方向
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                // 兰伯特漫反射光照颜色 = 光照颜色 * 材质漫反射颜色 * max(0, dot(标准化的法线向量, 标准化的光照方向向量))
                fixed3 color = _LightColor0.rgb * _MainColor.rgb * max(0, dot(normalize(data.normal), lightDir));
                // 为了背光区域不是全黑色的
                color = UNITY_LIGHTMODEL_AMBIENT.rgb + color;
                return fixed4(color.rgb, 1);
            }
            ENDCG
        }
    }
}