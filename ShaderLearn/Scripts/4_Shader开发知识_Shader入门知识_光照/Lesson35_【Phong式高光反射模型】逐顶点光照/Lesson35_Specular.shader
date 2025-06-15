Shader "Lesson/Lesson35_Specular"
{
    Properties
    {
        // 高光反射颜色
        _MainColor ("MainColor", Color) = (1,1,1,1)
        // 光泽度
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

            fixed4 _MainColor;
            float _SpecularNum;

            struct v2f
            {
                float4 pos : SV_POSITION;
                fixed3 color : COLOR;
            };

            v2f vert (appdata_base v)
            {
                v2f o;
                // 转换世界空间坐标到裁剪空间
                o.pos = UnityObjectToClipPos(v.vertex);
                // 标准化后观察方向向量
                // 将模型空间下的顶点坐标转换到世界空间下
                // unity_ObjectToWorld/UNITY_MATRIX_M：从模型空间转化到世界空间下的转换矩阵
                float3 worldPos = mul(unity_ObjectToWorld, v.vertex);
                // 视角坐标 - 顶点坐标
                float3 viewDir = normalize(_WorldSpaceCameraPos.xyz - worldPos);
                // 光照方向 （世界空间下）
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                // 世界空间下的法线信息
                float3 normal = UnityObjectToWorldNormal(v.normal.xyz);
                // 光照反射方向向量 = reflect(光照方向, 顶点法线向量)
                float3 reflectDir = reflect(-lightDir, normal);
                // 高光反射光照颜色 = 光源颜色 * 材质高光反射颜色 * pow(max(0, dot(normal(视角方向向量), 反射方向向量)), 幂（光泽度）)
                fixed3 color = _LightColor0.rgb * _MainColor.rgb * pow(max(0, dot(viewDir, reflectDir)), _SpecularNum);
                // o.color = UNITY_LIGHTMODEL_AMBIENT.rgb + color;
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