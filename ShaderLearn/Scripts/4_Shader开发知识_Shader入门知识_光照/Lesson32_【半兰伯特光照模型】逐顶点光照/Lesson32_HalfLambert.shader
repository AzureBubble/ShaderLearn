Shader "Lesson/Lesson32_HalfLambert"
{
    Properties
    {
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
                float4 pos : SV_POSITION;
                fixed3 color : COLOR;
            };

            fixed4 _MainColor;

            v2f vert (appdata_base v)
            {
                v2f data;
                // 模型空间顶点信息转换成裁剪空间顶点信息
                data.pos = UnityObjectToClipPos(v.vertex);
                // 光照方向
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                // 法线向量
                float3 normal = normalize(UnityObjectToWorldNormal(v.normal));

                // cosθ 范围： -1 ~ 1     * 0.5 + 0.5 限制范围：0 ~ 0.5 不抛弃背光方向的光照处理
                // 半兰伯特光照颜色 = 光照颜色 * 材质漫反射颜色 * (dot(标准化的法线向量, 标准化的光照方向向量) * 0.5 + 0.5)
                fixed3 color = _LightColor0 * _MainColor * (dot(normal, lightDir) * 0.5 + 0.5);
                data.color = color;
                data.color = UNITY_LIGHTMODEL_AMBIENT.rgb + color;

                return data;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                return fixed4(i.color.rgb, 1);
            }
            ENDCG
        }
    }
}