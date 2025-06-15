using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson25 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 CG内置文件的位置和作用
        //我们可以在Unity的安装目录中找到CG内置文件
        //在Editor―>Data―>CGIncludes中
        //后缀为cginc的文件为CG语言内置文件
        //后缀为glslinc的文件为GLSL语言内置文件

        //他们是预定义的Shader文件
        //里面包含了一些已经写好的Shader相关逻辑
        //作用和CG内置函数一样，可以提升我们的Shader开发效率
        //可以直接使用其中的方法等内容来进行逻辑开发

        //Unity中常用的内置文件有
        //1.UnityCG.cginc                     包含最常用的帮助函数、宏和结构体等
        //2.Lighting.cginc                    包含各种内置光照模型。如果编写的是Surface Shader(标准表面着色器），会自动包含进来
        //3.UnityShaderVariables.cginc        编译UnityShader时，会自动包含进来。包含许多内置的全局变量
        //4.HLSLSupport.cginc                 编译UnityShader时，会自动包含进来。声明了很多用于跨平台编译的宏和定义
        //等等
        #endregion

        #region 知识点二 如何使用CG内置文件
        //在CG语句块中进行引用
        //通过编译指令
        //#include "内置文件名.cginc"
        //的形式进行引用
        //我们便可以在CG语言中使用其中的内容

        //注意：一些常用的函数、宏、变量，可以不用引用，Unity会在编译时自动识别
        //     但是为了避免报错，建议都引用

        //"宏"通常指的是一种预处理指令或代码片段，用于在代码中进行文本替换。
        //宏允许程序员定义一个标识符（通常以大写字母表示）来代表一个代码片段，
        //然后在编译时将这个标识符替换为相应的代码，这种替换过程称为宏展开。

        //说人话：就是为一些代码片段，取一个别名，方便使用。在真正编译时在把这个别名翻译成对应的代码。
        #endregion

        #region 知识点三 常用内容

        #region 方法(UnigyCG.cginc中)
        //1.float3 WorldSpaceViewDir(float4 v)
        //  输入一个模型空间中的顶点位置，返回世界空间中从该点到摄像机的观察方向

        //2.float3 ObjSpaceViewDir(float4 v)
        //  输入一个模型空间中的顶点位置，返回模型空间中从该点到摄像机的观察方向

        //3.float3 WorldSpaceLightDir(float4 v)
        //  仅用于向前渲染中。输入一个模型空间中的顶点位置，返回世界空间中从该点到光源的光照方向。（返回值没有被归一化）

        //4.flaot3 ObjSpaceLightDir(float4 v)
        //  仅用于向前渲染中。输入一个模型空间中的顶点位置，返回模型空间中从该点到光源的光照方向。（返回值没有被归一化）

        //5.float3 UnityObjectToWorldNormal(float3 norm)
        //  把法线方向从模型空间转换到世界空间中

        //6.float3 UnityObjectToWorldDir(in float3 dir)
        //  把方向矢量从模型空间转换到世界空间中

        //7.float3 UnityWorldToObjectDir(float3 dir)
        //  把方向矢量从世界空间转换到模型空间中

        //等等
        #endregion

        #region 结构体(UnigyCG.cginc中)
        //1.appdata_base
        //  用于顶点着色器输入
        //  顶点位置、顶点法线、第一组纹理坐标

        //2.appdata_tan
        //  用于顶点着色器输入
        //  顶点位置、顶点法线、顶点切线、第一组纹理坐标

        //3.appdata_full
        //  用于顶点着色器输入
        //  顶点位置、顶点法线、顶点切线、四组（或更多）纹理坐标

        //4.appdata_img
        //  用于顶点着色器输入
        //  顶点位置、第一组纹理坐标

        //5.v2f_img
        //  用于顶点着色器输出
        //  裁剪空间中的位置，纹理坐标

        //等等
        #endregion

        #region 变换矩阵宏(UnityShaderVariables.cginc中)
        //坐标空间变换顺序
        //  模型空间 -> 世界空间 -> 观察空间 -> 裁剪空间 -> 屏幕空间

        //1.UNITY_MATRIX_MVP
        //  当前的模型*观察*投影矩阵，用于将顶点/方向向量从模型空间变换到裁剪空间中

        //2.UNITY_MATRIX_MV
        //  当前的模型*观察矩阵，用于将顶点/方向向量从模型空间变换到观察空间中

        //3.UNITY_MATRIX_V
        //  当前的观察矩阵，用于将顶点/方向向量从世界空间变换到观察空间中

        //4.UNITY_MATRIX_P
        //  当前的投影矩阵，用于将顶点/方向向量从观察空间变换到裁剪空间中

        //5.UNITY_MATRIX_VP
        //  当前的观察*投影矩阵，用于将顶点/方向向量从世界空间变换到裁剪空间中

        //6.UNITY_MATRIX_T_MV
        //  UNITY_MATRIX_MV的转置矩阵

        //7.UNITY_MATRIX_IT_MV
        //  UNITY_MATRIX_MV的逆转置矩阵，用于将法线从模型空间变换到观察空间，也可用于得到UNITY_MATRIX_MV的逆矩阵

        //8._Object2World
        //  当前的模型矩阵，用于将顶点/方向矢量从模型空间变换到世界空间

        //9._World2Object
        //  _Object2World的逆矩阵，用于将顶点/方向矢量从世界空间变换到模型空间

        //等等
        #endregion

        #region 变量
        //1._Time (不用引用，直接使用即可)
        //  自关卡加载以来的时间（t/20、t、t*2、t*3）用于对着色器内的事物进行动画处理
        //2._LightColor0 (向前渲染时，UnityLightingCommon.cginc；延迟渲染，UnityDeferredLibrary.cginc)
        //  光的颜色
        //等等
        #endregion

        #endregion

        #region 总结
        //CG中的内置文件和内置函数一样
        //是用于帮助我们进行Shader开发的
        //利用其中的函数、宏、全局变量等内容
        //可以提升我们Shader的开发效率
        //我们需要做的是，将这些常用内容记到笔记中
        //之后进行查阅
        //如果想要了解更多的内置内容可以参阅Unity官网的资料
        //内置文件相关：https://docs.unity3d.com/Manual/SL-BuiltinIncludes.html
        //函数相关：https://docs.unity3d.com/Manual/SL-BuiltinFunctions.html
        //宏相关：https://docs.unity3d.com/Manual/SL-BuiltinMacros.html
        //变量相关：https://docs.unity3d.com/Manual/SL-UnityShaderVariables.html
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
