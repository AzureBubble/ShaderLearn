using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson29 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 关键知识回顾
        //公式：
        //漫反射光照颜色 = 光源的颜色 * 材质的漫反射颜色 * max（0, 标准化后物体表面法线向量· 标准化后光源方向向量）

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

        #region 知识点 利用兰伯特光照模型实现光照效果（逐顶点光照）
        //关键步骤
        //1.材质漫反射颜色属性声明
        //2.渲染标签Tags设置 将LightMode光照模式 设置为ForwardBase向前渲染（通常用于不透明物体的基本渲染）
        //3.引用内置文件UnityCG.cginc和Lighting.cginc
        //4.结构体声明
        //5.基于公式实现逻辑
        //
        //注意：为了阴影出不全黑，需要加上兰伯特环境光颜色公共变量
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
