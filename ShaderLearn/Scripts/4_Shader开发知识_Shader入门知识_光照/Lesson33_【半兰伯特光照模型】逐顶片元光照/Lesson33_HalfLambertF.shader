Shader "Lesson/Lesson33_HalfLambertF"
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

            fixed3 _MainColor;

            struct v2f
            {
                float4 pos : SV_POSITION;
                float3 normal : NORMAL;
            };

            v2f vert (appdata_base v)
            {
                v2f o;
                // 模型空间顶点信息转换成裁剪空间顶点信息
                o.pos = UnityObjectToClipPos(v.vertex);
                // 法线向量
                o.normal = normalize(UnityObjectToWorldNormal(v.normal));
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // 光照方向
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);

                // cosθ 范围： -1 ~ 1     * 0.5 + 0.5 限制范围：0 ~ 0.5 不抛弃背光方向的光照处理
                // 半兰伯特光照颜色 = 光照颜色 * 材质漫反射颜色 * (dot(标准化的法线向量, 标准化的光照方向向量) * 0.5 + 0.5)
                fixed3 color = _LightColor0 * _MainColor * (dot(i.normal, lightDir) * 0.5 + 0.5);
                color = UNITY_LIGHTMODEL_AMBIENT.rgb + color;
                return fixed4(color.rgb, 1);
            }
            ENDCG
        }
    }
}