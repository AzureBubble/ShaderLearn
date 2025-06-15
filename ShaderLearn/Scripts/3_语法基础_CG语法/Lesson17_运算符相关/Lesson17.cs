using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 比较运算符
        //CG语言中比较运算符包括
        //大于 >
        //小于 <
        //大于等于 >=
        //小于等于 <=
        //等于 ==
        //不等于 !=

        //CG中的比较运算符的使用和C#中一样
        //运算结果为bool值
        #endregion

        #region 知识点二 条件运算符
        //CG语言中条件运算符（三目(三元)运算符）

        // condition ? value_if_true : value_if_false

        // condition 是一个条件表达式
        // 如果为真将返回 value_if_true
        // 否则返回 value_if_false

        //CG中的条件运算符的使用和C#中一样
        #endregion

        #region 知识点三 逻辑运算符
        //CG语言中逻辑运算符包括
        //逻辑或运算符 ||
        //逻辑与运算符 &&
        //逻辑非运算符 !

        //CG中的逻辑运算符的使用和C#中一样
        //唯一需要注意的是：CG中不存在C#中的"短路"操作
        #endregion

        #region 知识点四 数学运算符
        //CG语言中数学运算符包括
        //加法 +
        //减法 -
        //乘法 *
        //除法 /
        //取余 %
        //自增减 ++ --
        //CG中的数学运算符的使用和C#中一样
        //唯一需要注意的是：CG中取余符号只能向整数取余
        #endregion

        #region 总结
        //CG语法中比较、条件、逻辑、数学等运算符的使用和C#中一致
        //需要注意的是：
        //1.逻辑运算符在CG中不存在C#中的"短路"操作
        //2.数学运算符在CG中取余符号只能向整数取余
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
