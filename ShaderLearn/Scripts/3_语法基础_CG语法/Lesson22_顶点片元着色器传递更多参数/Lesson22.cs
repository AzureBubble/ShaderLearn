using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson22 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 顶点着色器获取更多数据信息
        //当我们在顶点着色器当中想要获取更多模型相关信息时
        //可以使用结构体对数据进行封装
        //通过对结构体中成员变量加语义的方式来定义想要获取的信息
        #endregion

        #region 知识点二 片元着色器获取更多数据信息
        //当我们在片元着色器当中想要获取更多信息时
        //采用的方式还是封装结构体的方式
        //注意：
        //片元着色器中获取的数据基本上都是由顶点着色器传递过来的
        //所以我们封装的结构体还需要作为顶点着色器的返回值类型
        #endregion

        #region 总结
        //如果顶点/片元着色器想要传递更多参数
        //我们需要通过结构体进行封装，用语义修饰结构体成员变量来达到目的
        //注意：
        //只有顶点/片元着色器的回调函数相关参数和返回值才需要通过语义修饰
        //一般的自定义函数是不需要语义的
        //因为我们自己调用自己的自定义函数是可以明确知道每个参数的作用的
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
