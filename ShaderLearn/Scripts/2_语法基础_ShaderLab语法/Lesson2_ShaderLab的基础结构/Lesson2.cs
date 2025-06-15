using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 什么是ShaderLab
        //上节课我们学到
        //Unity Shader是对Shader的一种封装
        //它是对底层图形渲染技术的封装，它提供了一种叫做ShaderLab的语言
        //来让我们更加轻松的编写和管理着色器

        //ShaderLab其实就是Unity自定义的一种语法规则
        //是用于在Untiy中编写和管理着色器的专门的语言
        //它提供了一种结构化的方式来描述Unity着色器的各个部分
        //从而让我们可以更轻松的创建和管理着色器

        //总而言之：
        //无论我们编写哪种类型的Shader，或是选择哪种语言去编写Shader
        //在Unity中总会通过ShaderLab语言对其进行包装和组织
        //它是Unity自定义的一种语法规则
        #endregion

        #region 知识点二 ShaderLab的基本结构
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

        //我们创建的所有Shader，都是基于ShaderLab的这些语法规则的
        //我们可以来观察下创建的一些默认Shader内容
        #endregion

        #region 总结

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
