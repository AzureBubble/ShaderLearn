using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson23 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识回顾 ShaderLab属性相关
        //Unity Shader的属性主要分成三大类：数值、颜色和向量、纹理贴图
        //属性的基本语法
        //  _Name("Display Name", type) = defaultValue[{options}]

        //  _Name: 属性名字，规则是需要在前面加一个下划线，方便在之后获取
        //  Display Name:材质面板上显示的名字
        //  type:属性的类型
        //  defaultValue:将Shader指定给材质的时候初始化的默认值

        //数值类型有三种：
        //1.整形
        //_Name("Display Name", Int) = number
        //2.浮点型
        //_Name("Display Name", Float) = number
        //3.范围浮点型
        //_Name("Display Name", Range(min,max)) = number

        //4.颜色
        //_Name("Display Name", Color) = (number1,number2,number3,number4)
        //注意：颜色值中的RGBA的取值范围是 0~1 （映射0~255）
        //5.向量
        //_Name("Display Name", Vector) = (number1,number2,number3,number4)
        //注意：向量值中的XYZW的取值范围没有限制

        //6.2D 纹理（最常用的纹理，漫反射贴图、法线贴图都属于2D纹理）
        //_Name("Display Name", 2D) = "defaulttexture"{}

        //7.2DArray 纹理（纹理数组，允许在纹理中存储多层图像数据，每层看做一个2D图像，一般使用脚本创建，较少使用，了解即可）
        //_Name("Display Name", 2DArray) = "defaulttexture"{}

        //8.Cube map texture纹理（立方体纹理，由前后左右上下6张有联系的2D贴图拼成的立方体，比如天空盒和反射探针）
        //_Name("Display Name", Cube) = "defaulttexture"{}

        //9.3D纹理（一般使用脚本创建，极少使用，了解即可）
        //_Name("Display Name", 3D) = "defaulttexture"{}
        #endregion

        #region 知识点一 CG中变量类型的对应ShaderLab的属性类型
        //       ShaderLab属性类型          CG变量类型
        //         Color,Vector          float4,half4,fixed4
        //        Range,Float,Int        float,half,fixed
        //             2D                  sampler2D
        //            Cube                 samplerCube
        //             3D                  sampler3D
        //           2DArray             sampler2DArray
        #endregion

        #region 知识点二 如何在CG语句块中使用ShaderLab中声明的属性
        //直接在CG语句块中
        //声明和属性中对应类型的同名变量即可
        #endregion

        #region 总结
        //ShaderLab中声明的属性都是需要在Shader(着色器)逻辑中使用的
        //我们需要在CG中声明和属性对应类型的同名变量
        //这样就可以在之后的Shader(着色器)逻辑中去利用它实现对应的逻辑了

        //我们需要掌握的就是ShaderLab属性类型和CG变量类型的对应关系
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
