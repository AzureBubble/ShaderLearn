using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson46 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 内置光照计算相关函数是什么？
        //我们在实现光照模型时
        //经常会进行一些数学计算
        //比如 坐标、法线相关的转换
        //在UnityCG.cginc中提供了一些常用的函数
        //可以帮助我们快捷的进行数学计算

        //比如我们之前将法线从模型空间转换到世界空间的方法
        //UnityObjectToWorldNormal 等

        //有了这些内置函数，我们就不需要自己去通过数学计算来得到结果了
        //直接调用API即可得到我们想要的结果

        //除了之前我们在课程中用到的一些函数外
        //还有一些其他的内置函数
        //这节课我们主要就是对他们进行了解
        #endregion

        #region 知识点二 常用内置函数
        //1. float3 WorldSpaceViewDir(float4 v)
        //   传入模型空间下的顶点位置，返回世界空间中从该点到摄像机的观察方向

        //2. float3 UnityWorldSpaceViewDir(flaot4 v)
        //   传入世界空间中的顶点位置，返回世界空间中从该点到摄像机的观察方向

        //3. float3 ObjSpaceViewDir(float4 v)
        //   传入模型空间中的顶点位置，返回模型空间中从该点到摄像机的观察方向

        //4. float3 WorldSpaceLightDir(float4 v)
        //   (仅用于向前渲染中)
        //   传入模型空间中的顶点位置，返回世界空间中该点到光源的光照方向（没有归一化）

        //5. float3 UnityWorldSpaceLightDir(float4 v)
        //   (仅用于向前渲染中)
        //   传入世界空间中的顶点位置，返回世界空间中从该点到光源的光照方向（没有归一化）

        //6. float3 ObjSpaceLightDir(float4 v)
        //   (仅用于向前渲染中)
        //   传入模型空间中的顶点位置，返回模型空间中从该点到光源的光照方向（没有归一化）

        //7. float3 UnityObjectToWorldNormal(float3 normal)
        //   把法线从模型空间转换到世界空间中

        //8. float3 UnityObjectToWorldDir(float3 dir)
        //   把方向矢量从模型空间转换到世界空间中

        //9. float3 UnityWorldToObjectDir(float3 dir)
        //   把方向矢量从世界空间转换到模型空间中   

        //10.float4 UnityObjectToClipPos(float4 v)
        //   输入模型空间中的顶点位置，返回裁剪空间下的顶点位置
        #endregion

        #region 总结
        //可以把这些常用函数记到笔记中
        //以后使用时翻看回忆即可
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
