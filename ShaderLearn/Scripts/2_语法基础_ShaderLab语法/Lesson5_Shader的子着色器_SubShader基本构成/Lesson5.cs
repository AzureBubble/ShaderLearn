using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
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
        //          //顶点-片段着色器 或 表面着色器 或 固定函数着色器
        //      }
        //      SubShader
        //      {
        //          //更加精简的版本
        //          //目的是适配旧设备
        //      }
        //      .....可以有n个SubShader代码块

        //      //第四部分
        //      Fallback "备用的Shader"
        //}
        #endregion

        #region 知识点一 SubShader语句块的作用
        //每一个Shader中都会包含至少一个SubShader
        //当Unity想要显示一个物体的时候
        //就会在Shader文件中去检测这些SubShader语句块
        //然后选择第一个能够在当前显卡运行的SubShader进行执行
        //因此在一个Shader当中实现一些高级效果时
        //为了避免在在某些设备上无法执行
        //可能会存在多个SubShader语句块，用于适配这些低端设备

        //SubShader当中包含最终的渲染相关代码，决定了最终的渲染效果
        #endregion

        #region 知识点二 SubShader的基本构成
        //SubShader语句块中主要由3部分构成
        //1.渲染标签：通过标签来确定什么时候以及如何对物体进行渲染
        //2.渲染状态：通过状态来确定渲染时的剔除方式、深度测试方式、混合方式等等内容
        //3.渲染通道：具体实现着色器代码的地方（每个SubShader语句块中至少有一个渲染通道，可以有多个）

        //第三部分
        //SubShader
        //{
        //  1.渲染标签
        //  Tags{ "标签名1" = "标签值1" "标签名2" = "标签值2" .....}
        //
        //  2.渲染状态
        //  .....
        //
        //  3.渲染通道
        //  Pass
        //  {
        //      第一个渲染通道
        //  }
        //  Pass
        //  {
        //      第二个渲染通道
        //  }
        //  .............
        //}

        //注意：
        //在SubShader中每定义一个渲染通道Pass，就会让物体执行一次渲染
        //n个Pass，就会有n次渲染，在实现一些复杂渲染效果时需要使用多个Pass进行组合实现
        //但是我们要尽量减少它的数量，更多的Pass会增加性能消耗
        #endregion

        #region 总结
        //SubShader子着色器基本构成为：
        //             --------Tags(渲染标签)
        //            |--------States(渲染状态)
        //SubShader---|--------Pass(渲染通道1)
        //            |--------Pass(渲染通道2)
        //            |--------....(渲染通道n)

        //在Shader文件中可以存在多个SubShader语句块
        //当Unity想要显示一个物体的时候
        //会在Shader文件中去检测这些SubShader语句块
        //然后选择第一个能够在当前显卡运行的SubShader进行执行
        //因此在一个Shader当中实现一些高级效果时
        //为了避免在在某些设备上无法执行
        //可能会存在多个SubShader语句块，用于适配这些低端设备
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
