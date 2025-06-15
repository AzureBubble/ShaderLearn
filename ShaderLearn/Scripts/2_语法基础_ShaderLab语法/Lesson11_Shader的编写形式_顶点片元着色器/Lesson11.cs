using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识回顾
        //表面着色器是Unity对顶点/片元着色器的封装
        //可以用更少的代码实现复杂的逻辑
        //但是性能和可控性较差
        //它的特点是
        //1.直接在SubShader语句块中书写着色器逻辑
        //2.我们不需要关心也不需要使用多个Pass，每个Pass如何渲染，Unity会在内部帮助我们去处理
        //3.可以使用CG或HLSL两种Shader语言去编写Shader逻辑
        //4.代码量较少，可控性较低，性能消耗较高
        //5.适用于处理需要和各种光源打交道的着色器，但是在移动平台上需要注意性能表现
        #endregion

        #region 知识点 顶点/片元着色器
        //我们可以在创建Shader时，选择创建Unlit Shader来快速创建顶点/片元着色器模板
        //通过观察，我们发现
        //顶点/片元着色器的着色器代码是编写在Pass语句块中
        //我们需要自己定义每个Pass需要使用的Shader代码
        //虽然比起表面着色器来说我们需要编写的代码较多
        //但是好处是灵活性更高，可控性更强，可以控制更多的渲染细节
        //决定对性能影响的高低

        //它的特点是
        //1.需要在Pass渲染通道中编写着色器逻辑
        //2.可以使用CG或HLSL两种Shader语言去编写Shader逻辑
        //3.代码量较多，灵活性较强，性能消耗更可控，可以实现更多渲染细节
        //4.适用于光照处理较少，自定义渲染效果较多时（移动平台首选）
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}