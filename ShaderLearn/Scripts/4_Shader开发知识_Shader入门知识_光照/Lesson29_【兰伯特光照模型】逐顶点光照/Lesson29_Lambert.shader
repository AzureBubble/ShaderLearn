Shader "Lesson/Lesson29_Lambert"
{
    Properties
    {
        // 材质的漫反射颜色
        _MainColor("MainColor", Color) = (1,1,1,1)
    }
    SubShader
    {
        // 设置光照模式 ForwardBase：这种向前渲染模式 主要用来处理 不透明物体的光照渲染的
        Tags { "LightMode"="ForwardBase" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // 引用对应的内置文件
            // 主要是为了之后的 比如 内置结构体使用 内置变量使用
            #include "UnityCG.cginc"
            #include "Lighting.cginc"

            // 材质漫反射颜色
            fixed4 _MainColor;

            // 顶点着色器传递给片元着色器的内容
            struct v2f
            {
                float4 pos:SV_POSITION; // 裁剪空间下的顶点坐标信息
                fixed3 color:COLOR; // 对应顶点的漫反射光照颜色
            };

            // 逐顶点光照 所以相关的漫反射光照颜色的计算 需要写在顶点着色器 回调函数中
            v2f vert (appdata_base v)
            {
                v2f v2fData;
                // 把模型空间下的顶点坐标转换成裁剪空间下的顶点坐标信息
                v2fData.pos = UnityObjectToClipPos(v.vertex);
                // 光照颜色 _LightColor0

                // 在模型空间下的法线
                //v.normal
                // 获取到相对于世界坐标系下的 法线信息
                float3 normal = UnityObjectToWorldNormal(v.normal);
                // 光源方向
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);

                // 计算兰伯特光照漫反射颜色: 光照颜色 * 材质漫反射颜色 * max(0, 标准化的法线向量 · 标准化的光照方向向量)
                fixed3 color = _LightColor0.rgb * _MainColor.rgb * max(0, dot(normal, lightDir));
                // 记录颜色 传递给片元着色器 背光地方是全黑的
                // v2fData.color = color;

                // 加上兰伯特光照模型环境光变量的目的 是希望阴影处不要全黑 不然看起来有一些不自然
                // 目的就是为了让表现效果更接近于真实世界 所以需要加上它
                v2fData.color = UNITY_LIGHTMODEL_AMBIENT.rgb + color;
                return v2fData;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // 把计算好的兰伯特漫反射颜色传递出去就可以了
                return fixed4(i.color.rgb, 1);
            }
            ENDCG
        }
    }
}