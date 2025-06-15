using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson34 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 Phong式高光反射光照模型的来历和原理
        //来历:
        //高光反射光照模型没有单一的发明者，因为有多种计算的方式
        //和半兰伯特光照模型一样，是经过很多从业者的研究和发展而演化出来的
        //其中比较关键的几位贡献者为
        //Phong光照模型的提出者：
        //  裴祥风（Bui-Tuong Phong，越南裔美国计算机学家）
        //Blinn-Phone光照模型的提出者：
        //  吉姆·布林（Jim Blinn，美国计算机科学家）

        //原理:
        //Phong式高光反射光照模型的理论是
        //基于光的反射行为和观察者的位置决定高光反射的表现效果
        //认为高光反射的颜色和 光源的反射光线以及观察者位置方向向量夹角的余弦成正比
        //并且通过对余弦值取n次幂来表示光泽度（或反光度）
        #endregion

        #region 知识点二 Phong式高光反射光照模型的公式
        //公式：
        //高光反射光照颜色 = 光源的颜色 * 材质高光反射颜色 * max（0, 标准化后观察方向向量· 标准化后的反射方向）幂
        //1.标准化后观察方向向量· 标准化后的反射方向 得到的结果就是 cosθ
        //2.幂 代表的是光泽度  余弦值取n次幂
        #endregion

        #region 知识点三 如何在Shader中获取公式中的关键信息
        //1.观察者的位置（摄像机的位置）
        //  _WorldSpaceCameraPos
        //2.相对于法向量的反射向量 方法
        //  reflect(入射向量,顶点法向量) 返回反射向量
        //3.指数幂 方法
        //  pow(底数，指数) 返回计算结果
        #endregion

        #region 总结
        //Phong式高光反射
        //高光反射光照颜色 = 光源的颜色 * 材质高光反射颜色 * max（0, 标准化后观察方向向量· 标准化后的反射方向）幂
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
