using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson42 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点 利用Blinn-Phong式高光反射光照模型实现光照效果（逐片元光照）
        //公式
        //高光反射光照颜色 = 光源的颜色 * 材质高光反射颜色 * max（0, 标准化后顶点法线方向向量 · 标准化后半角向量方向向量）幂
        
        //关键步骤
        //基本和逐顶点一致
        //区别：
        //1.在顶点着色器中计算顶点和法线相关数据
        //2.在片元着色器中计算Blinn Phong式高光反射光照
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
