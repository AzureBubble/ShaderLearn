using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
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

        #region 知识点 Shader的名字
        //1.直接修改Shader文件中 Shader后的名字即可
        //2.Shader的名字决定了在材质面板的选择路径

        //注意：
        //1.不要使用中文命名我们的Shader
        //2.Shader的文件名和在文件中的命名建议保持一致
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

