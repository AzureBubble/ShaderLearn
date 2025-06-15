using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson19 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 注意
        //CG语法中的函数声明和使用几乎和C#中一模一样
        #endregion

        #region 知识点一 无返回值的函数
        //基本结构
        //void name(in 参数类型 参数名, out 参数类型 参数名)
        //{
        //      函数体
        //}
        //void：以void开头，表示没有返回值
        //name：函数的名称
        //in：表示是输入参数，表示由函数外部传递给函数内部，内部不会修改该参数，只会使用该参数进行计算，允许有多个
        //out：表示是输出参数，表示由函数内部传递给函数的调用者，在函数内部必须对该参数值进行初始化或修改，允许有多个

        //注意：
        //in和out都可以省略，省略后就没有了in和out相关的限制
        //虽然可以省略，但是建议大家在编写Shader时不要省略in和out
        //因为他们可以明确参数的传递方式，提高代码的可读性和可维护性
        //可以让我们更容易的理解函数是如何与参数交互的，减少潜在的误解可能
        #endregion

        #region 知识点二 有返回值的函数
        //基本结构
        //type name(in 参数类型 参数名)
        //{
        //      函数体
        //      return 返回值;
        //}
        //type：返回值类型
        //return：返回指定类型的数据

        //注意：
        //虽然可以在有返回值的函数中使用out参数
        //但是这并不是常见做法，除非是一些自定义逻辑函数
        //对于顶点/片元着色器函数只会使用单返回值的方式进行处理
        #endregion

        #region 总结
        //CG当中的函数声明和函数使用和C#中基本一致

        //区别主要是CG中的in和out关键字
        //1.in表示输入参数，用于外部传给内部，内部只会用，不会改，可以有多个
        //2.out表示输出参数，用于内部传给外部，内部必须初始化或修改，可以有多个

        //对于有返回值的函数，要不采用返回值形式，要不采用out
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
