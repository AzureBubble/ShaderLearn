using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 基础数据类型
        //uint      32为无符号整形
        //int       32位整形

        //float     32位浮点数 符号:f
        //half      16位浮点数 符号:h
        //fixed     12位浮点数 

        //bool      布尔类型
        //string    字符串

        //sampler 纹理对象句柄
        //  sampler:     通用的纹理采样器，可以用于处理各种不同维度和类型的纹理
        //  sampler1D:   用于一维纹理，通常用于对一维纹理进行采样，例如从左到右的渐变色
        //  sampler2D:   用于二维纹理，最常见的纹理类型之一。它用于处理二维图像纹理，例如贴图
        //  sampler3D:   用于三维纹理，通常用于体积纹理，例如体积渲染
        //  samplerCUBE: 用于立方体纹理，通常用于处理环境映射等需要立方体贴图的情况
        //  samplerRECT: 用于处理矩形纹理，通常用于一些非标准的纹理映射需求
        //  他们都是用于处理纹理（Texture）数据的数据类型
        //  他们的主要区别是纹理的维度和类型
        #endregion

        #region 知识点二 基础复合数据类型
        //数组：和C#中类似
        //一维
        //int a[4] = {1,2,3,4}
        //长度
        //a.length

        //二维
        //int b[2][3] = {{1,2,3},{4,5,6}}
        //长度 
        //b.length为2
        //b[0].length为3

        //结构体
        //和C#基本一样
        //没有访问修饰符
        //结构体声明结束加分号
        //一般在函数外声明
        #endregion

        #region 总结
        //CG中的基础数据类型和C#中基本一致
        //重要区别是
        //1.多了几种浮点数类型 half和fixed
        //2.多了纹理类型 sampler
        //3.数组的声明有些许区别
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
