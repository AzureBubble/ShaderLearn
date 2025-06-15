using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson32 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点 利用半兰伯特光照模型实现光照效果（逐顶点光照）
        //半兰伯特光照模型的逐顶点实现
        //和兰伯特一模一样
        //唯一的区别就是公式
        //漫反射光照颜色 = 光源的颜色 * 材质的漫反射颜色 *（（标准化后物体表面法线向量・ 标准化后光源方向向量）* 0.5 + 0.5）
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
