Shader "TeachShader/Lesson22"
{
    Properties
    {
        
    }
    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            //该结构体
            //是用于从应用阶段获取对应语义数据后
            //传递给顶点着色器回调函数的
            struct a2v
            {
                //顶点坐标(基于模型空间)
                float4 vertex:POSITION;
                //顶点法线(基于模型空间)
                float3 normal:NORMAL;
                //纹理坐标(uv坐标)
                float2 uv:TEXCOORD0;
            };


            //从顶点着色器传递给片元着色器的 结构体数据 
            //同样这里面的成员也需要用语义去进行修饰
            struct v2f
            {
                //裁剪空间下的坐标
                float4 position:SV_POSITION;
                //顶点法线(基于模型空间)
                float3 normal:NORMAL;
                //纹理坐标(uv坐标)
                float2 uv:TEXCOORD0;
            };

            v2f vert(a2v data)
            {
                //需要传递给片元着色器的数据
                v2f v2fData;
                v2fData.position = UnityObjectToClipPos(data.vertex);
                v2fData.normal = data.normal;
                v2fData.uv = data.uv;

                return v2fData;
            }

          
            fixed4 frag(v2f data):SV_Target
            {
                return fixed4(0,1,0,1);
            }
            ENDCG
        }
    }
}