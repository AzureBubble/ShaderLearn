using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
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

        //渲染标签：通过标签来确定什么时候以及如何对物体进行渲染
        #endregion

        #region 知识点一 渲染标签的语法结构
        //Tags{ "标签名1" = "标签值1" "标签名2" = "标签值2" "标签名2" = "标签值2" .......}

        //渲染标签是通过键值对的形式进行声明的
        //并且没有数量限制，可以使用任意多个标签
        #endregion

        #region 知识点二 渲染队列Queue
        //主要作用：
        //确定物体的渲染顺序

        //Tags{ "Queue" = "标签值" }
        //常用Unity预先定义好的渲染队列标签值：

        //1.Background(背景)(队列号:1000)
        //  最早被渲染的物体的队列，一般用来渲染天空盒或者背景
        //  Tags{ "Queue" = "Background" }

        //2.Geometry(几何)(队列号:2000)
        //  不透明的几何体通常使用该队列，当没有声明渲染队列时，Unity会默认使用这个队列
        //  Tags{ "Queue" = "Geometry" }

        //3.AlphaTest(透明测试)(队列号:2450)
        //  有透明通道的，需要进行Alpha测试的几何体会使用该队列
        //  当所有Geometry队列实体绘制完后再绘制AlphaTest队列，效率更高
        //  Tags{ "Queue" = "AlphaTest" }

        //4.Transparent(透明的)(队列号:3000)
        //  该队列中几何体按照由远到近的顺序进行绘制，半透明物体的渲染队列，所有进行透明混合的几何体都应该使用该队列
        //  比如：玻璃材质，粒子特效等
        //  Tags{ "Queue" = "Transparent" }

        //5.Overlay(覆盖)(队列号:4000)
        //  用是放在最后渲染的队列，于叠加渲染的效果，比如镜头光晕等
        //  Tags{ "Queue" = "Overlay" }

        //6.自定义队列
        //  基于Unity预先定义好的这些渲染队列标签来进行加减运算来定义自己的渲染队列
        //  比如：
        //  Tags{ "Queue" = "Geometry+1" }    代表的队列号就是 2001
        //  Tags{ "Queue" = "Transparent-1" } 代表的队列号就是 2999
        //  自定义队列在一些特殊情况下，特别有用
        //  比如 一些水的渲染 想要在不透明物体之后，半透明物体之前进行渲染，就可以自定义

        //  注意：自定义队列只能基于预先定义好的各类型进行计算，不能在Shader中直接赋值数字
        //       如果实在想要直接赋值数字，可以在材质面板中进行设置
        #endregion

        #region 知识点三 渲染类型RenderType
        //主要作用：
        //对着色器进行分类，之后可以用于着色器替换功能
        //摄像机上有对应的API，可以指定这个渲染类型来替换成别的着色器

        //Tags{ "RenderType" = "标签值" }
        //常用Unity预先定义好的渲染类型标签值：

        //1.Opaque(不透明的)
        //  用于普通Shader，比如：不透明、自发光、反射等
        //2.Transparent(透明的)
        //  用于半透明Shader，比如：透明、粒子
        //3.TransparentCutout(透明切割)
        //  用于透明测试Shader，比如：植物叶子
        //4.Background(背景)
        //  用于天空盒Shader
        //5.Overlay(覆盖)
        //  用于GUI纹理、Halo（光环）、Flare（光晕）

        //了解即可
        //6.TreeOpaque
        //  用于地形系统中的树干
        //7.TreeTransparentCutout
        //  用于地形系统中的树叶
        //8.TreeBillboard
        //  用于地形系统中的Billboarded树
        //9.Grass
        //  用于地形系统中的草
        //10.GrassBillboard
        //  用于地形系统中的Billboarded草
        #endregion

        #region 知识点四 禁用批处理
        //主要作用：
        //当使用批处理时，模型会被变换到世界空间中，模型空间会被丢弃
        //这可能会导致某些使用模型空间顶点数据的Shader最终无法实现想要的结果
        //可以通过开启禁用批处理来解决该问题

        //总是禁用批处理
        //Tags{ "DisableBatching" = "True" }

        //不禁用批处理（默认值）
        //Tags{ "DisableBatching" = "False" }

        //了解即可
        //LOD效果激活时才会禁用批处理，主要用于地形系统上的树
        //Tags{ "DisableBatching" = "LODFading" }
        #endregion

        #region 知识点五 禁止阴影投影
        //主要作用：
        //控制该SubShader的物体是否会投射阴影

        //不投射阴影
        //Tags{ "ForceNoShadowCasting" = "True" }
        //投射阴影（默认值）
        //Tags{ "ForceNoShadowCasting" = "False" }
        #endregion

        #region 知识点六 忽略投影机
        //主要作用：
        //物体是否受到Projector（投影机）的投射
        //Projector是Unity中的一个功能（以后讲解）

        //忽略Projector（一般半透明Shader需要开启该标签）
        //Tags{ "IgnoreProjector" = "True" }

        //不忽略Projector（默认值）
        //Tags{ "IgnoreProjector" = "False" }
        #endregion

        #region 知识点七 其他标签
        //1.是否用于精灵
        //想要将该SubShader用于Sprite时，将该标签设置为False
        //Tags{ "CanUseSpriteAtlas" = "False" }

        //2.预览类型
        //材质在预览窗口默认为球形，如果想要改变为平面或天空盒
        //只需要改变预览标签即可
        //平面
        //Tags{ "PreviewType" = "Panel" }
        //天空盒
        //Tags{ "PreviewType" = "SkyBox" }
        #endregion

        #region 知识点八 渲染标签的注意实现
        //以上这些标签只能在SubShader语句块中声明
        //之后讲解的Pass渲染通道语句块中也可以声明渲染标签
        //但是今天讲解的内容都不能在Pass中声明
        //Pass中有自己专门的标签类型，我们会在之后讲解
        #endregion

        #region 总结
        //渲染标签其实都是以键值对的形式出现的配置
        //键和值都是字符串类型
        //这些渲染标签是SubShader和渲染引擎之间的沟通桥梁
        //我们可以利用渲染标签来告诉Unity我们希望如何以及何时渲染这个对象

        //这些内容，大家可以将其记入自己的笔记当中
        //之后在使用他们时，翻看笔记即可
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
