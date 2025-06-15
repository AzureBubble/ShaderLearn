using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson35 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 关键知识点回顾
        //高光反射光照颜色 = 光源的颜色 * 材质高光反射颜色 * max（0, 标准化后观察方向向量· 标准化后的反射方向）幂

        //1.观察者的位置（摄像机的位置）
        //  _WorldSpaceCameraPos
        //2.相对于法向量的反射向量 方法
        //  reflect(入射向量,顶点法向量) 返回反射向量
        //3.指数幂 方法
        //  pow(底数，指数) 返回计算结果
        #endregion

        #region 知识点 利用Phong式高光反射光照模型实现光照效果（逐顶点光照）
        //关键步骤
        //1.属性声明（材质高光反射颜色、光泽度）
        //2.渲染标签Tags设置 将LightMode光照模式 设置为ForwardBase向前渲染（通常用于不透明物体的基本渲染）
        //3.引用内置文件UnityCG.cginc和Lighting.cginc
        //4.结构体声明
        //5.基本公式实现逻辑
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
