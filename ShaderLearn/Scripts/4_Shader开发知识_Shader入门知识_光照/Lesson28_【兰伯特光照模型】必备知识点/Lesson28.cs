using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson28 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 两个颜色相乘
        //两个颜色变量相乘，通常用于计算光照、材质混合、纹理混合等等需求
        //它是一种用于混合颜色的操作
        //计算结果可以理解为两种颜色叠加在一起的效果
        //在颜色相乘中，通常是使用颜色通道的值来执行逐通道的乘法
        //举例：
        //颜色A、B都是 fixed4 类型的变量
        //颜色A * 颜色B = (A.r * B.r, A.g * B.g, A.b * B.b, A.a * B.a);
        //那么得到的这个结果就是A、B颜色叠加后的结果

        //总结：
        //两个颜色变量相乘，得到的结果表示两个颜色叠加在一起
        #endregion

        #region 知识点二 漫反射基本概念
        //漫反射（Diffuse Reflection）是光线撞击一个物体表面后以各个方向均匀地反射出去的过程
        //在漫反射下，光线以无规律的方式散射，而不像镜面反射那样按照特定的角度反射。
        //这种散射导致了物体表面看起来均匀而不闪烁的效果。
        #endregion

        #region 知识点三 兰伯特光照模型的来历和原理
        //兰伯特(Lambert)光照模型，也称为朗伯反射模型
        //是由瑞士数学家约翰·海因里希·朗伯（Johann Heinrich Lambert）于1760年左右首次提出
        //朗伯是18世纪的一个杰出科学家，他在光学和数学领域作出了众多贡献。
        //兰伯特光照模型描述了漫反射表面对光线的反射行为，它成为计算机图形学和渲染中重要的基础模型之一

        //原理：
        //兰伯特光照模型的理论是
        //认为漫反射光的强度仅与入射光的方向和反射点处表面法线的夹角的余弦成正比
        #endregion

        #region 知识点四 兰伯特光照模型的公式
        //公式：
        //漫反射光照颜色 = 光源的颜色 * 材质的漫反射颜色 * max（0, 标准化后物体表面法线向量· 标准化后光源方向向量）
        //其中：
        //1.标准化后物体表面法线向量· 标准化后光源方向向量 得到的结果就是 cosθ
        //2.max(0,cosθ)的目的是避免负数，对于模型背面的部分，认为找不到光，直接乘以0，变为黑色
        #endregion

        #region 知识点五 如何在Shader中获取公式中的关键信息
        //1.光源的颜色
        //  Lighting.cginc 内置文件中的 _LightColor0
        //2.光源的方向
        //  _WorldSpaceLightPos0 表示光源0在世界坐标系下的位置
        //3.向量归一化方法
        //  normalize
        //4.取最大值方法
        //  max
        //5.点乘方法
        //  dot
        //6.兰伯特光照模型环境光变量（用于模拟环境光对物体的影响，避免物体阴影部分完全黑暗）
        //  UNITY_LIGHTMODEL_AMBIENT.rgb
        //7.将法线从模型空间转换到世界空间
        //  UnityObjectToWorldNormal
        #endregion

        #region 总结
        //兰伯特光照模型
        //漫反射光颜色 = 光源的颜色 * 材质的漫反射颜色 * max（0, 标准化后物体表面法线向量· 标准化后光源方向向量）
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
