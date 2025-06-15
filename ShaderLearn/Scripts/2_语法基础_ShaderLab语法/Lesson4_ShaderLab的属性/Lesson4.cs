using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
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

        #region 知识点一 Shader的属性的作用
        //在Shader编写时我们经常会用到不同类型的变量或贴图等资源
        //为了增加Shader的可调节性，有些变量不会直接在Shader程序中写死
        //而是作为开放的属性显示在我们的材质面板上，供我们使用时调节
        //而这些开放的属性就是通过属性来定义的
        //Shader的属性具有两个特点
        //1.可以在材质面板被编辑
        //2.可以在后续当作输入变量提供给所有子着色器使用
        #endregion

        #region 知识点二 Shader的属性的基本语法
        //1.在Shader文件中
        //  Shader属性是存在于Shader语句块中的Properties属性语句块
        //  我们只需要在Properties语句块中按照语法规则声明属性即可

        //2.Unity Shader的属性主要分成三大类：数值、颜色和向量、纹理贴图

        //3.属性的基本语法
        //  _Name("Display Name", type) = defaultValue[{options}]

        //  _Name: 属性名字，规则是需要在前面加一个下划线，方便在之后获取
        //  Display Name:材质面板上显示的名字
        //  type:属性的类型
        //  defaultValue:将Shader指定给材质的时候初始化的默认值

        //例子：
        //第一部分
        //Shader "着色器名字" 
        //{ 
        //      //第二部分
        //      Properties
        //      {
        //          //材质面板上可以看到的属性
        //          _Name("Display Name", type) = defaultValue[{options}]
        //      }

        //      //第三、四部分
        //      .......
        //      .......
        //}
        #endregion

        #region 知识点三 数值类型属性
        //数值类型有三种：
        //1.整形
        //_Name("Display Name", Int) = number
        //2.浮点型
        //_Name("Display Name", Float) = number
        //3.范围浮点型
        //_Name("Display Name", Range(min,max)) = number

        //注意：Unity Shader中的数值类型属性基本都是浮点型(Float)数据
        //     虽然提供了整数(Int)，但是编译时最终都会转换为浮点型
        //     因此我们更多的使用的还是Float类型
        #endregion

        #region 知识点四 颜色和向量类型属性
        //颜色和向量类型属性之所以归纳在一起
        //是因为
        //颜色是由RGBA四个分量代表
        //向量是由XYZW四个分量代表
        //他们都可以由一个四个数组成的类型表示

        //1.颜色
        //_Name("Display Name", Color) = (number1,number2,number3,number4)
        //注意：颜色值中的RGBA的取值范围是 0~1 （映射0~255）
        //2.向量
        //_Name("Display Name", Vector) = (number1,number2,number3,number4)
        //注意：向量值中的XYZW的取值范围没有限制
        #endregion

        #region 知识点五 纹理贴图类型属性
        //纹理贴图类型有四种
        //1.2D 纹理（最常用的纹理，漫反射贴图、法线贴图都属于2D纹理）
        //_Name("Display Name", 2D) = "defaulttexture"{}

        //2.2DArray 纹理（纹理数组，允许在纹理中存储多层图像数据，每层看做一个2D图像，一般使用脚本创建，较少使用，了解即可）
        //_Name("Display Name", 2DArray) = "defaulttexture"{}

        //3.Cube map texture纹理（立方体纹理，由前后左右上下6张有联系的2D贴图拼成的立方体，比如天空盒和反射探针）
        //_Name("Display Name", Cube) = "defaulttexture"{}

        //4.3D纹理（一般使用脚本创建，极少使用，了解即可）
        //_Name("Display Name", 3D) = "defaulttexture"{}

        //注意：
        //1.关于defaulttexture默认值取值
        //  不写:默认贴图为空
        //  white:默认白色贴图（RGBA:1,1,1,1）
        //  black:默认黑色贴图（RGBA:0,0,0,1）
        //  gray:默认灰色贴图（RGBA:0.5,0.5,0.5,1）
        //  bump:默认凸贴图（RGBA:0.5,0.5,1,1）,一般用于法线贴图默认贴图
        //  red：默认红色贴图（RGBA:1,0,0,1）

        //2.关于默认值后面的 {} ,固定写法（老版本中括号内可以控制固定函数纹理坐标的生成，但是新版本中没有该功能了）

        #endregion

        #region 总结
        //Shader的属性主要就是三种类型
        //数值、颜色和向量、纹理贴图
        //我们只需要掌握属性声明的基础语法即可
        //它的主要是：
        //1.可以在材质面板被编辑
        //2.可以在后续当作输入变量提供给所有子着色器使用
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}