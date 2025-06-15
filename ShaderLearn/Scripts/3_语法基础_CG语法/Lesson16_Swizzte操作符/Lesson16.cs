using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 什么是Swizzle操作符
        //上节课我们学习了向量
        //但是我们并没有讲解如何获取向量中某元素的相关知识点
        //而这节课将要学习的Swizzle操作符就可以用于获取向量中元素

        //Swizzle操作符通常以点号(.)的形式使用，后面跟着所需的分量顺序
        //对于四维向量来说
        //我们可以通过
        //向量.xyzw 
        //或
        //向量.rgba
        //两种分量的写法来表示向量中的四个值
        //其中 xyzw和rgba分别代表四维向量中的四个元素
        //在此的意义就是向量一般可以用来表示坐标和颜色
        #endregion

        #region 知识点二 如何使用Swizzle操作符
        //1.利用它来提取分量
        //2.利用它来重新排列分量
        //3.利用它来创建新向量
        #endregion

        #region 知识点三 向量和矩阵的更多用法

        #region 1.利用向量声明矩阵
        //在声明矩阵时，我们可以配合向量来进行声明
        #endregion

        #region 2.获取矩阵中的元素
        //矩阵中元素的获取和二维数组一样
        #endregion

        #region 3.利用向量获取矩阵中的某一行
        //我们可以用向量作为容器存储矩阵中的某一行
        #endregion

        #region 4.高维转低维
        //向量和矩阵都可以用低维存高维，会自动舍去多余元素
        #endregion

        #endregion

        #region 总结
        //1.向量获取元素可以利用Swizzle操作符获取
        //2.矩阵获取元素和二维数组获取方式一样
        //3.Swizzle操作符可以让我们对向量进行方便的操作
        //4.向量和矩阵在声明和获取时可以配合使用
        //5.高维向量或矩阵可以用低维容器装载，可以利用这个特点将4维变3维，4x4变3x3
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
