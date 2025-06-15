using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
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

        #region 知识点一 Shader的形式是什么？
        //通过之前的课程，我们已经对Shader文件的文件结构有一定的认识
        //并且学习了ShaderLab语法相关的知识

        //通过学习我们知道 在Unity Shader当中我们可以通过ShaderLab语法去设置很多内容
        //比如属性、渲染状态、渲染标签等等
        //但是其最主要的作用是需要指定各种着色器所需的代码

        //而这些着色器代码即可以放在SubShader子着色器语句块中，也可以放在其中的Pass渲染通道语句块中
        //不同的Shader形式放置着色器代码的位置也有所不同

        //我们一般会使用以下3种形式来编写Unity Shader
        //1.表面着色器（可控性较低）
        //2.顶点/片元着色器（重点学习）
        //3.固定函数着色器（基本已弃用，了解即可）
        #endregion

        #region 知识点二 表面着色器
        //表面着色器（Surface Shader）是Unity自己创造的一种着色器代码类型
        //它的本质是对顶点/片元着色器的一层封装
        //它需要的代码量很少，很多工作都帮助我们去完成了
        //但是缺点是渲染的消耗较大，可控性较低
        //它的优点在于，它帮助我们处理了很多光照细节，我们可以直接使用而无需自己计算实现光照细节

        //我们可以在创建Shader时，选择创建Standard Surface Shader
        //通过观察该Shader文件的内部结构，你会发现
        //着色器相关代码被放在SubShader语句块中（并非Pass）的 CGPROGRAM 和 ENDCG 之间

        //表面着色器的特点就是
        //1.直接在SubShader语句块中书写着色器逻辑
        //2.我们不需要关心也不需要使用多个Pass，每个Pass如何渲染，Unity会在内部帮助我们去处理
        //3.可以使用CG或HLSL两种Shader语言去编写Shader逻辑
        //4.代码量较少，可控性较低，性能消耗较高
        //5.适用于处理需要和各种光源打交道的着色器（主机、PC平台时更适用，移动平台需要考虑性能消耗）
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}