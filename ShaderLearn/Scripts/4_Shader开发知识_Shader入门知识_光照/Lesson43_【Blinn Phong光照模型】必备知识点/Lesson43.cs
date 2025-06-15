using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson43 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 Blinn Phong光照模型的来历和原理
        //来历：
        //Blinn Phong光照模型我们之前提到过
        //它是由吉姆·布林（Jim Blinn，美国计算机科学家）
        //在1977年时，在Phong光照模型基础上进行修改提出的
        //它和Phong一样是一个经验模型，并不符合真实世界中的光照现象
        //它们只是看起来正确

        //原理：
        //Blinn Phong和Phong光照模型一样，认为物体表面反射光线是由三部分组成的
        //环境光 + 漫反射光 + 镜面反射光（高光反射光）
        #endregion

        #region 知识点二 Blinn Phong光照模型的公式
        // Blinn Phong光照模型公式：
        //物体表面光照颜色 = 环境光颜色 + 漫反射光颜色 + 高光反射光颜色
        //其中：
        //环境光颜色 = UNITY_LIGHTMODEL_AMBIENT(unity_AmbientSky、unity_AmbientEquator、unity_AmbientGround)
        //漫反射光颜色 = 兰伯特光照模型 计算得到的颜色
        //高光反射光颜色 = Blinn Phong式高光反射光照模型 计算得到的颜色
        #endregion

        #region 总结
        //Blinn Phong光照模型公式：
        //物体表面光照颜色 = 环境光颜色 + 兰伯特光照模型所得颜色 + Blinn Phong式高光反射光照模型所得颜色
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
