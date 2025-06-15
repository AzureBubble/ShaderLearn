using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson37 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 两个颜色相加
        //我们在学习兰伯特光照模型时了解了两个颜色相乘
        //它的作用是让两个颜色叠加在一起
        //用两个颜色的RGBA值各自相乘得到一个新的颜色

        //而两个颜色相加的作用 同样是让两个颜色叠加在一起
        //它和两个颜色相乘的区别是：
        //相乘: 颜色相乘时，最终颜色会往黑色靠拢
        //      计算两个颜色混合时一般用颜色相乘
        //      因为真实世界中多个颜色混在一起最终会变成黑色

        //相加: 颜色相加时，最终颜色会往白色靠拢
        //      计算光照反射时一般用颜色相加，因为向白色靠拢能带来 更亮的感觉，复合光的表现
        #endregion

        #region 知识点二 Unity Shader中的环境光
        //我们在学习兰伯特和半兰伯特光照模型时
        //在计算完漫反射光照后，加上了一个环境光变量 UNITY_LIGHTMODEL_AMBIENT
        //那么这个环境光变量其实是可以在Unity中进行设置的

        //Window——>Rendering——>Lighting
        //Environment(环境)页签中的Environment Lighting(环境光)
        //这里可以设置环境光来源
        //当是Skybox和Color时，我们可以通过 UNITY_LIGHTMODEL_AMBIENT 获取到对应环境光颜色
        //当是Gradient（渐变）时，通过以下3个成员可以得到对应的环境光
        //  unity_AmbientSky（周围的天空环境光）
        //  unity_AmbientEquator（周围的赤道环境光）
        //  unity_AmbientGround（周围的地面环境光）

        //注意：
        //这些内置变量都包含在 UnityShaderVariables.cginc 中
        //在编译时，会自动包含该文件，可以不用手动包含
        #endregion

        #region 知识点三 Phong光照模型的来历和原理
        //来历：
        //Phong光照模型我们之前提到过
        //它是由裴祥风（Bui-Tuong Phong，越南裔美国计算机学家）
        //在1975年时，提出的一种局部光照经验模型

        //原理：
        //裴祥风认为物体表面反射光线是由三部分组成的
        //环境光 + 漫反射光 + 镜面反射光（高光反射光）
        #endregion

        #region 知识点四 Phong光照模型的公式
        //Phong光照模型公式：
        //物体表面光照颜色 = 环境光颜色 + 漫反射光颜色 + 高光反射光颜色
        //其中：
        //环境光颜色 = UNITY_LIGHTMODEL_AMBIENT(unity_AmbientSky、unity_AmbientEquator、unity_AmbientGround)
        //漫反射光颜色 = 兰伯特光照模型 计算得到的颜色
        //高光反射光颜色 = Phong式高光反射光照模型 计算得到的颜色
        #endregion

        #region 总结
        //Phong光照模型公式：
        //物体表面光照颜色 = 环境光颜色 + 兰伯特光照模型所得颜色 + Phong式高光反射光照模型所得颜色
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
