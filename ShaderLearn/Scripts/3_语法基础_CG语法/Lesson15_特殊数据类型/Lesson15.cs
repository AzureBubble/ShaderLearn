using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 向量
        //向量类型属于CG语言的内置数据类型

        //内置的向量类型是基于基础数据类型声明的
        //向量的最大维度不超过4维
        //数据类型可以是任意数值类型
        //基本构成
        //数据类型2 = 数据类型2(n1,n2)
        //数据类型3 = 数据类型3(n1,n2,n3)
        //数据类型4 = 数据类型4(n1,n2,n3,n4)
        #endregion

        #region 知识点二 矩阵
        //矩阵类型属于CG语言的内置数据类型

        //矩阵的最大行列不大于4，不小于1
        //数据类型可以是任意数值类型
        //基本构成
        //数据类型'n'x'm' = {n1m1,n1m2,n1m3.....}
        //数据类型2x2
        //数据类型3x3
        //数据类型4x4
        #endregion

        #region 知识点三 bool类型特殊使用
        //bool类型同样可以用于如同向量一样声明
        //它可以用于存储一些逻辑判断结果
        //比如
        //float3 a = float3(0.5, 0.0, 1.0);
        //float3 b = float3(0.6, -0.1, 0.9);
        //bool3 c = a < b;
        //运算后向量c的结果为bool3(true, false, false)
        #endregion

        #region 总结
        //1.向量最大维度不超过4维
        //2.矩阵最大行列不大于4，不小于1，在赋值时一定注意行列的关系
        //3.bool向量可以用来存储向量之间比较的结果

        //注意：CG中向量，矩阵和数组是完全不同的，向量和矩阵是内置的数据类型，而数组则是一种数据结构，不是内置数据类型
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
