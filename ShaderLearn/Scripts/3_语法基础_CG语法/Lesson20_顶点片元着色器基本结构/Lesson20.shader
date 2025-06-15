// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "TeachShader/Lesson20"
{
    Properties
    {
        
    }
    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex myVert
            #pragma fragment myFrag

            //顶点着色器 回调函数 
            //POSITION 和 SV_POSITION是CG语言的语义
            //POSITION：把模型的顶点坐标填充到输入的参数v当中
            //SV_POSITION：顶点着色器输出的内容是裁剪空间中的顶点坐标
            //如果没有这些语义来限定输入和输出参数的话，那么渲染器就完全不知道用户输入输出的是什么，就会得到错误的效果
            float4 myVert(float4 v:POSITION):SV_POSITION
            {
                //mul是CG语言提供的矩阵和向量的乘法运算函数（就是一个内置的函数）
                //UNITY_MATRIX_MVP 代表一个变换矩阵 是Unity内置的模型、观察、投影矩阵的集合
                //UnityObjectToClipPos它的作用和之前的矩阵乘法是一样的，主要目的就是在进行坐标变换 只不过新版本将其封装起来了 使用更加方便
                //mul(UNITY_MATRIX_MVP,v);
                return UnityObjectToClipPos(v);
            }

            //片元着色器 回调函数
            //SV_Target:告诉渲染器，把用户输出颜色存储到一个渲染目标中，这里将输出到默认的帧缓存中
            fixed4 myFrag():SV_Target
            {
                return fixed4(0,1,0,1);
            }

            ENDCG
        }
    }
}