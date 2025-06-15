using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson40 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 Blinn-Phong式高光反射光照模型的来历和原理
        //来历
        //通过我们之前知识的学习
        //Phong式高光反射光照模型 是 Phong光照模型的一部分
        //因此很容易推测出 Blinn-Phong式高光反射光照模型
        //其实也是Blinn-Phong光照模型的一部分，主要是用于计算高光反射颜色的
        //Blinn-Phone光照模型的提出者：
        //吉姆·布林（Jim Blinn，美国计算机科学家）

        //原理:
        //Blinn-Phong式高光反射光照模型的理论是
        //它是对Phong式高光反射光照模型的改进
        //它不再使用反射向量计算镜面反射，而是使用半角向量来进行计算
        //半角向量为视角方向和灯光方向的角平分线方向

        //认为高光反射的颜色和 顶点法线向量以及半角向量夹角的余弦成正比
        //并且通过对余弦值取n次幂来表示光泽度（或反光度）
        #endregion

        #region 知识点二 Blinn-Phong式高光反射光照模型的公式
        //公式：
        //高光反射光照颜色 = 光源的颜色 * 材质高光反射颜色 * max（0, 标准化后顶点法线方向向量 · 标准化后半角向量方向向量）幂
        //1.标准化后顶点法线方向向量 · 标准化后半角向量方向向量 得到的结果就是 cosθ
        //2.半角向量方向向量 = 视角单位向量 + 入射光单位向量
        //3.幂 代表的是光泽度  余弦值取n次幂
        #endregion

        #region 知识点三 Phong和Blinn-Phong的区别
        //由于两个光照模型中高光反射光照模型的计算方式不一样
        //从而会带来一些表现上的不同
        //1.高光散射
        //  Blinn-Phong模型的高光通常会产生相对均匀的高光散射，这会使物体看起来光滑而均匀。
        //  Phong模型的高光可能会呈现更为锐利的高光散射，因为它基于观察者和光源之间的夹角。
        //  这可能导致一些区域看起来特别亮，而另一些区域则非常暗。
        //2.高光锐度
        //  Blinn-Phong模型的高光通常具有较广的散射角，因此看起来不那么锐利。
        //  Phong模型的高光可能会更加锐利，特别是在观察者和光源夹角较小时，可能表现为小而亮的点。
        //3.光滑度和表面纹理
        //  Blinn-Phong模型通常更适合表现光滑的表面，因为它考虑了表面微观凹凸之间的相互作用，使得光照在表面上更加均匀分布。
        //  Phong模型有时更适合表现具有粗糙表面纹理的物体，因为它的高光散射可能会使纹理和细节更加突出。
        //4.镜面高光大小
        //  Blinn-Phong模型通常产生的镜面高光相对较大，但均匀分布。
        //  Phong模型可能会产生较小且锐利的镜面高光。
        #endregion

        #region 总结
        //Blinn-Phong式高光反射
        //高光反射光照颜色 = 光源的颜色 * 材质高光反射颜色 * max（0, 标准化后顶点法线方向向量 · 标准化后半角向量方向向量）幂
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
