using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 CG语句写在哪里？
        //对于顶点\片元着色器来说
        //CG语句需要写在Pass渲染通道语句块中
        //我们需要在Pass语句块中
        //加入指令
        //CGPROGRAM

        //在这两个指令之间 就是我们书写CG代码的地方

        //ENDCG
        #endregion

        #region 知识点二 重要的编译指令 ―― 指定着色器函数
        //在真正书写CG代码之前
        //我们需要先使用 #pragma 声明编译指令
        //我们目前只学习 指定顶点\片元着色器函数的 编译指令
        //其他相关编译指令我们以后再学习

        //定义实现 顶点/片元着色器 代码的函数名称
        //#pragma vertex name(实现顶点着色器的函数名)
        //#pragma fragment name(实现片元着色器的函数名)

        //这两个编译指令的作用是将顶点\片元着色器实现定位到两个函数中
        //之后我们只需要在这两个函数中书写Shader逻辑即可
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
