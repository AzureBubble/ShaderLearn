using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识回顾
        //SubShader子着色器基本构成为：
        //             --------Tags(渲染标签)
        //            |--------States(渲染状态)
        //SubShader---|--------Pass(渲染通道1)
        //            |--------Pass(渲染通道2)
        //             --------....(渲染通道n)

        //渲染通道：具体实现着色器代码的地方（每个SubShader语句块中至少有一个渲染通道，可以有多个）
        #endregion

        #region 知识点一 渲染通道的语法结构
        //Pass{
        //  1.Name 名称
        //  2.渲染标签
        //  3.渲染状态
        //  4.其他着色器代码
        //}
        #endregion

        #region 知识点二 Pass的名字
        //主要作用：
        //我们对Pass命名的主要目的
        //可以利用UsePass命令在其他Shader当中复用该Pass的代码,
        //只需要在其他Shader当中使用
        //UsePass "Shader路径/Pass名"
        //注意：
        //Unity内部会把Pass名称转换为大写字母
        //因此在使用UsePass命令时必须使用大写形式的名字

        //Pass{
        //  Name MyPass
        //}

        //在其他Shader中复用该Pass代码时
        //UsePass "TeachShader/Lesson4/MYPASS"
        #endregion

        #region 知识点三 Pass中的渲染标签
        //Pass中的渲染标签语法和SubShader中相同
        //Tags{ "标签名1" = "标签值1" "标签名2" = "标签值2" "标签名2" = "标签值2" .......}
        //但是我们之前讲解过的SubShader语句块中的渲染标签不能够在Pass中使用
        //Pass当中有自己专门的渲染标签

        #region 1.Tags{ "LightMode" = "标签值" }
        //1.Tags{ "LightMode" = "标签值" }
        //主要作用：
        //指定了该Pass应该在哪个阶段执行
        //可以将着色器代码分配给适当的渲染阶段，以实现所需的效果

        //1-1.Always
        //    始终渲染；不应用光照
        //1-2.ForwardBase
        //    在前向渲染中使用；应用环境光、主方向光、顶点/SH 光源和光照贴图
        //1-3.ForwardAdd
        //    在前向渲染中使用；应用附加的每像素光源（每个光源有一个通道）
        //1-4.Deferred
        //    在延迟渲染中使用；渲染 G 缓冲区
        //1-5.ShadowCaster
        //    将对象深度渲染到阴影贴图或深度纹理中
        //1-6.MotionVectors
        //    用于计算每对象运动矢量
        //1-7.PrepassBase
        //    在旧版延迟光照中使用；渲染法线和镜面反射指数
        //1-8.PrepassFinal
        //    在旧版延迟光照中使用；通过组合纹理、光照和反光来渲染最终颜色
        //1-9.Vertex
        //    当对象不进行光照贴图时在旧版顶点光照渲染中使用；应用所有顶点光源
        //1-10.VertexLMRGBM
        //    当对象不进行光照贴图时在旧版顶点光照渲染中使用；在光照贴图为 RGBM 编码的平台上（PC 和游戏主机）
        //1-11.VertexLM
        //    当对象不进行光照贴图时在旧版顶点光照渲染中使用；在光照贴图为双 LDR 编码的平台上（移动平台）

        //关于向前渲染、延迟渲染、旧版光照等概念了解
        //https://docs.unity.cn/cn/2019.4/Manual/RenderingPaths.html
        #endregion

        #region 2.Tags{ "RequireOptions" = "标签值" }
        //2.Tags{ "RequireOptions" = "标签值" }
        //主要作用：
        //用于指定当满足某些条件时才渲染该Pass

        //目前Unity仅支持
        //Tags{ "RequireOptions" = "SoftVegetation" }
        //仅当Quality窗口中开启了SoftVegetation时才渲染此通道
        #endregion

        #region 3.Tags{ "PassFlags" = "标签值" }
        //3.Tags{ "PassFlags" = "标签值" }
        //主要作用：
        //一个渲染通道Pass可指示一些标志来更改渲染管线向Pass传递数据的方式

        //目前Unity仅支持
        //Tags{ "PassFlags" = "OnlyDirectional" }
        //在 ForwardBase 向前渲染的通道类型中使用时，此标志的作用是仅允许主方向光和环境光/光照探针数据传递到着色器
        //这意味着非重要光源的数据将不会传递到顶点光源或球谐函数着色器变量
        #endregion

        #endregion

        #region 知识点四 Pass中的渲染状态
        //我们上节课在SubShader语句块中学习的渲染状态同样适用于Pass
        //比如
        //剔除方式决定了 模型正面背面是否能够被渲染
        //深度缓冲和深度测试 决定了景深关系的确定以及透明效果的正确表达等
        //混合方式 决定了透明半透明颜色的正确表现，以及一些特殊颜色效果的表现
        //这些渲染状态都可以在单个Pass中进行设置
        //需要注意的是
        //如果在SubShader语句块中使用会影响之后的所有渲染通道Pass
        //如果在Pass语句块中使用只会影响当前Pass渲染通道，不会影响其他的Pass

        //不仅如此，Pass中还可以使用固定管线着色器的命令
        #endregion

        #region 知识点五 其他着色器代码
        //其他代码部分就是实现着色器的核心代码部分
        //我们可能会用到CG或HLSL等着色器语言来进行逻辑书写
        //我们之后会详细讲解
        #endregion

        #region 知识点六 GrabPass命令
        // 我们可以利用GrabPass命令把即将绘制对象时的屏幕内容抓取到纹理中
        // 在后续通道中即可使用此纹理，从而执行基于图像的高级效果。

        //举例：
        //将绘制该对象之前的屏幕抓取到 _BackgroundTexture 中
        //GrabPass
        //{
        //    "_BackgroundTexture"
        //}
        //注意：
        //该命令一般写在某个Pass前，在之后的Pass代码中可以利用_BackgroundTexture变量进行处理
        #endregion

        #region 总结
        //Pass渲染通道语句块中
        //主要包含了
        //1.名字：可以帮助我们复用Pass代码
        //2.渲染标签：不能使用SubShader中的渲染标签，有自己独有的渲染标签
        //3.渲染状态：SubShader当中的渲染状态同样可以在Pass中使用，影响的区域不同
        //4.着色器语言逻辑：我们之后会详细学习的部分
        //四个部分
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}