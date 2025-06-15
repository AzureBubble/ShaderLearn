using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson21 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 语义的作用
        //CG语言中提供了 语义 这种特殊关键字用于修饰函数中的传入参数和返回值
        //它的主要作用是让Shader知道从哪里读取数据，并把数据输出到哪里
        //让我们在Shader开发当中可以获取到想要的数据，并且可以把数据传递出去

        //注意：Unity中只支持CG当中的部分语义
        #endregion

        #region 知识点二 常用语义

        #region 应用阶段――>顶点着色器
        //应用阶段传递模型数据给顶点着色器时Unity支持的语义
        //一般在顶点着色器回调函数的传入参数中应用

        //POSITION:
        //模型空间中的顶点位置，通常是float4类型

        //NORMAL:
        //顶点法线，通常是float3类型

        //TANGENT:
        //顶点切线，通常是float4类型

        //TEXCOORDn:
        //比如 TEXCOORD0,TEXCOORD1....
        //该顶点的纹理坐标，通常是float2或者float4类型
        //TEXCOORD0表示第一组纹理坐标，依次类推
        //纹理坐标：也称UV坐标，表示该顶点对应纹理图像上的位置

        //COLOR:
        //顶点颜色，通常是fixed4或float4类型
        #endregion

        #region 顶点着色器――>片元着色器
        //从顶点着色器传递数据给片元着色器时Unity支持的语义
        //一般在顶点着色器回调函数的返回值中应用

        //SV_POSITION:
        //裁剪空间中的顶点坐标（必备）

        //COLOR0:
        //通常用于输出第一组顶点颜色（不是必须的）

        //COLOR1:
        //通常用于输出第二组顶点颜色（不是必须的）

        //TEXCOORD0~TEXCOORD7:
        //通常用于输出纹理坐标（不是必须的）
        #endregion

        #region 片元着色器输出
        //片元着色器输出时Unity支持的常用语义
        //一般在片元着色器回调函数的返回值中应用

        //SV_Target:
        //输出值会存储到渲染目标中

        #endregion

        #endregion

        #region 知识点三 更多语义
        //HLSL语义汇总：
        //https://learn.microsoft.com/zh-cn/windows/win32/direct3dhlsl/dx-graphics-hlsl-semantics?redirectedfrom=MSDN
        //CG的语义大部分和HLSL的相同，在此做了解即可
        //以后我们用到其他语义时，再着重讲解即可
        #endregion

        #region 总结
        //语义的主要作用是让Shader知道从哪里读取数据，并把数据输出到哪里
        //我们在编写顶点片元着色器回调函数的相关逻辑时
        //我们需要使用语义去修饰函数参数和返回值
        //这样我们才能获取到我们想要的数据，并且把结果数据明确的返回出去用于下一流程处理

        //我们需要将常用语义记录下来，以便后续使用
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
