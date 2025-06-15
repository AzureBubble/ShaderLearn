using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    void Start()
    {
        #region 知识点一 Unity Shader 和 Shader的区别
        //Shader是一个更通用的概念，用于描述图形渲染程序中的着色器程序
        //而Unity Shader是特指在Unity中使用的着色器

        //你可以认为Unity Shader是对Shader的一种封装
        //它是对底层图形渲染技术的封装，它提供了一种叫做ShaderLab的语言
        //来让我们更加轻松的编写和管理着色器

        //我们在这一阶段主要对Unity Shader当中的ShaderLab进行学习
        //我们之后的学习在提到Shader这个词时，主要指的就是Unity Shader
        #endregion

        #region 知识点二 Unity中的材质和Shader
        //如果我们想要在Unity中体现出一个Shader的渲染效果
        //必须配合使用材质（Material)和 Shader（Unity Shader）才能达到目标

        //一般的使用流程是：
        //1.创建一个材质
        //2.创建一个Unity Shader，把该Shader赋给上一步中创建的材质
        //3.将材质赋予给想要渲染的对象
        //4.在材质面板中调整Unity Shader的相关属性，以达到最终效果

        //也就是说，Unity中的Shader必须配合材质才能正常使用
        //我们接下来就类分别的创建它们，来感受下他们的作用
        #endregion

        #region 知识点三 创建材质
        //我们可以在Project窗口中右键创建材质
        //Create ――> Material
        //1.创建好材质后，可以选中它后，在Inspector窗口中Shader选项中选择对应的着色器进行关联使用
        //2.Inspector窗口下方的内容就是选中的Shader提供的可编辑变化的相关变量，他们会直接影响渲染结果
        //3.关联好Shader后，材质需要赋值给GameObject对象上依附的Mesh Renderer等相关渲染器组件上进行使用

        //也就是说只要Unity Shader当中提供对应的可以编辑属性，我们就可以直接在材质中进行编辑
        //而不需要去修改Shader代码来达到不同效果了
        #endregion

        #region 知识点四 创建Shader
        //我们可以在Project窗口中右键创建Shader
        //Create ――> Shader
        //1.Standard Surface Shader（标准曲面着色器）
        //  包含标准光照模型的表面着色器模板
        //2.Unlit Shader
        //  不包含光照的基本顶点/片元着色器
        //3.Image Effect Shader
        //  用于实现屏幕后处理效果的基本模板
        //4.Compute Shader
        //  利用GPU并行计算一些和常规渲染流水线无关的内容
        //5.Ray Tracing Shader
        //  用于实现光线追踪效果的着色器

        //我们之后的学习重点主要是顶点/片元着色器
        //因此我们更多的会去学习 Unlit Shader 着色器的编写

        //我们可以先来认识下Shader文件在Inspector窗口上显示的内容
        #endregion

        #region 知识点五 配合使用
        //有了材质和Shader后，我们才能够将其配合在一起使用
        //只需要将材质设置为使用对应的着色器，并设置着色器提供的可编辑的相关属性
        //我们就可以利用他们来渲染出我们想要的各种效果了
        #endregion

        #region 总结
        //在Unity中，材质和Shader是密不可分的两兄弟
        //想要在Unity中使用Shader就必须要配合材质进行使用
        #endregion
    }
}