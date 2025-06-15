using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识回顾
        //ShaderLab主要由4个部分组成
        //1.Shader的名字
        //2.Shader的属性
        //3.1~n个子着色器
        //4.备用的Shader

        //第一部分
        //Shader "着色器名字" 
        //{ 
        //      //第二部分
        //      Properties
        //      {
        //          //材质面板上可以看到的属性
        //      }

        //      //第三部分
        //      SubShader
        //      {
        //           Tags(渲染标签)
        //           States(渲染状态)
        //           Pass(渲染通道1)
        //           Pass(渲染通道2)
        //           ....(渲染通道n)
        //      }
        //      SubShader
        //      {
        //           Tags(渲染标签)
        //           States(渲染状态)
        //           Pass(渲染通道1)
        //           Pass(渲染通道2)
        //           ....(渲染通道n)
        //      }
        //      .....可以有n个SubShader代码块

        //      //第四部分
        //      Fallback "备用的Shader"
        //}
        #endregion

        #region 知识点一 备用Shader的作用
        //我们知道ShaderLab当中允许有多个SubShader子着色器
        //当执行渲染时，会从上到下使用第一个能够正常执行的SubShader子着色器来渲染对象

        //那有没有可能所有SubShade子着色器都不能够在显卡上执行呢？
        //答案是肯定的
        //有可能出现在某一个设备上，我们自定义的所有SubShader都无法正常执行（设备显卡无法支持一些api等情况）
        //那么这时备用Shader就可以起到很大作用了，它至少可以让对象能够正常渲染出来

        //因此
        //备用Shader主要作用就是当Shader文件中的所有SubShader子着色器都无法正常运行时
        //起到一个保险作用，让物体能够使用一个最低级的Shader去渲染出来（效果略差，但至少能够显示）
        #endregion

        #region 知识点二 备用Shader的语法
        //Fallback "Shader名"
        //或者
        //Fallback Off

        //在Fallback关键词后面空格并通过一个字符串来告诉Unity
        //“最低级的Unity Shader”是谁
        //也可以直接关闭Fallback功能，但是如果关闭那就意味着“放弃治疗”
        #endregion

        #region 总结
        //备用Shader的语法非常简单 
        //Fallback "Shader名"
        //或者
        //Fallback Off

        //它的主要作用就是提供“救命稻草”
        //我们一般会使用较为低级的效果作为备用Shader
        //确保对象在低端设备上也能够正常渲染
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
