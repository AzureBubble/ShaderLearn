using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson24 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 CG内置函数是什么？
        //Unity Shader中的CG语言
        //提供了各种用于图形编程的函数
        //这些函数是CG为我们封装好的逻辑
        //我们可以使用它们来编写Unity Shader
        #endregion

        #region 知识点二 有哪些内置函数？

        #region 1.数学函数
        #region 三角函数相关
        //sincos(float x, out s, out c)     该函数同时计算x的sin值和cos值通过s和c进行返回（比分别运算快很多）
        //sin(x)                            正弦函数
        //cos(x)                            余弦函数
        //tan(x)                            正切函数
        //sinh(x)                           双曲正弦函数
        //cosh(x)                           双曲余弦函数
        //tanh(x)                           双曲正切函数
        //asin(x)                           反正弦函数，输入参数范围[-1,1]，返回[-π/2,π/2]区间的角度值
        //acos(x)                           反余弦函数，输入参数范围[-1,1]，返回[0,π]区间的角度值
        //atan(x)                           反正切函数，输入参数范围[-1,1]，返回[-π/2,π/2]区间的角度值
        //atan2(y,x)                        计算y/x的反正切值。和atan功能一样，只是输入参数不同。atan(x)=atan2(x,1)   
        #endregion

        #region 向量、矩阵相关
        //cross(A,B)                        叉乘（注意：传入向量必须是三维向量）
        //dot(A,B)                          点乘（注意：传入向量必须是三维向量）
        //mul(M,N)                          计算两个矩阵相乘
        //mul(M,v)                          计算矩阵和向量相乘
        //mul(v,M)                          计算向量和矩阵相乘
        //transpose(M)                      M为矩阵，计算M的转置矩阵
        //determinant(m)                    计算矩阵的行列式因子
        #endregion

        #region 数值相关
        //abs(x)                            返回输入参数的绝对值
        //ceil(x)                           对输入参数向上取整
        //floor(x)                          对输入参数向下取整
        //clamp(x,a,b)                      如果x小于a，则返回a；x大于b，则返回b；否则，返回x（"夹紧"函数）
        //radians(x)                        角度转弧度
        //degrees(x)                        弧度转角度
        //max(a,b)                          返回最大值
        //min(a,b)                          返回最小值
        //sqrt(x)                           求x的平方根，x必须大于0
        //pow(x,y)                          x的y次方的值
        //round(x)                          对x四舍五入
        //rsqrt(x)                          x的反平方根，x必须大于0
        //lerp(a,b,f)                       差值函数，计算(1-f)*a + b*f 或者 a + f*(b-a)的值

        //exp(x)                            计算e的x次方的值，e=2.71828182845904523536
        //exp2(x)                           计算2的x次方的值
        //fmod(x,y)                         返回x/y的余数，y不为0
        //frac(x)                           返回标量或每个矢量分量的小数部分
        //frexp(x,out exp)                  将浮点数x分解为尾数和直属，即 x = m * 2的exp次方，返回m，将指数存储exp中
        //isfinite(x)                       判断标量或者向量中的每个数据是否是有限数，如果是返回true，否则返回false
        //isinf(x)                          判断标量或者向量中的每个数据是否是无限，如果是返回true，否则返回false
        //isnan(x)                          判断标量或者向量中的每个数据是否是非数据，如果是返回true，否则返回false
        //ldexp(x,n)                        计算x * 2的n次方 的值
        //log(x)                            计算ln(x)的值，x必须大于0
        //log2(x)                           计算log2(x次方)的值，x必须大于0
        //log10(x)                          计算log2(x次方)的值，x必须大于0
        //saturate(x)                       如果x小于0，返回0；如果x大于1，返回1；否则，返回x
        //sign(x)                           如果x大于0，返回1；如果x小于0，返回-1；否则，返回0
        //smoothstep(min,max,x)             值x位于min、max区间内，如果x=min，返回0；如果x=max，返回1；如果在两者之间，返回
        //                                  -2* ((x-min)/(max - min))的三次方 + 3* ((x - min)/(max - min))的2次方
        //step(a,x)                         如果x<a,返回0；否则，返回1
        //all(x)                            输入参数均不为0，则返回true;否则返回False。相当于逻辑与&&
        //any(x)                            输入参数只要有其中一个不为0，则返回true。相当于逻辑或||
        #endregion

        #region 其他
        //lit(NdotL,NdotH,m)                N表示法向量；L表示入射光向量；H表示半角向量；m表示高光系数
        //                                  该函数计算环境光、散射光、镜面光的贡献，返回4维向量；
        //                                  x位表示环境光贡献；y位表示散射光贡献；z位表示镜面光贡献；w始终为1
        //noise(x)                          噪声函数，返回值始终是0~1之间；对于相同的输入，始终返回相同值，不是真正意义的随机噪声
        #endregion
        #endregion

        #region 2.几何函数
        //length(v)                     返回一个向量的模长
        //normalize(v)                  归一化向量
        //distance(p1,p2)               计算两点之间的距离
        //reflect(I,N)                  计算反射光方向向量，I为入射光，N为顶点法向量，。I是指向顶点的，I和N必须被归一化，必须是3维向量
        //refract(I,N,eta)              计算折射向量，I为入射光，N为顶点法向量，eta为折射系数。I是指向顶点的，I和N必须被归一化，必须是3维向量
        #endregion

        #region 3.纹理函数
        //注意：这些纹理采样函数返回值为 fixed4 类型的颜色值

        #region 二维纹理
        //tex2D(sampler2D tex, float2 s)                                    二维纹理查询
        //tex2D(sampler2D tex, float2 s, float2 dsdx, float2 dsdy)          使用导数值查询二维纹理
        //tex2D(sampler2D tex, float3 sz)                                   二维纹理查询，并进行深度值比较
        //tex2D(sampler2D tex, float3 sz, float2 dsdx, float2 dsdy)         使用导数值查询二维纹理，并进行深度值比较
        //tex2Dproj(sampler2D tex, float3 sq)                               二维投影纹理查询
        //tex2Dproj(sampler2D tex, float4 szq)                              二维投影纹理查询，并进行深度值比较
        #endregion

        #region 立方体纹理
        //texCUBE(samplerCUBE tex, float3 s)                                查询立方体纹理
        //texCUBE(samplerCUBE tex, float3 s, float3 dsdx, float3 dsdy)      结合导数值查询立方体纹理
        //texCUBEDproj(samplerCUBE tex, float4 sq)                          查询立方体投影纹理，并进行深度值比较
        #endregion

        #region 其他纹理
        //tex1D(sampler1D tex, float s)                                     一维纹理查询
        //tex1D(sampler1D tex, float s, float dsdx, float dsdy)             使用导数值查询一维纹理
        //tex1D(sampler1D tex, float2 sz)                                   一维纹理查询，并进行深度值比较
        //tex1D(sampler1D tex, float2 sz, float dsdx, float dsdy)           使用导数值查询一维纹理，并进行深度值比较
        //tex1Dproj(sampler1D tex, float2 sq)                               一维投影纹理查询
        //tex1Dproj(sampler1D tex, float3 szq)                              一维投影纹理查询，并进行深度值比较

        //texRECT(samplerRECT tex, float2 s)                                矩形纹理查询
        //texRECT(samplerRECT tex, float2 s, float2 dsdx, float2 dsdy)      使用导数值查询矩形纹理
        //texRECT(samplerRECT tex, float3 sz)                               矩形纹理查询，并进行深度值比较
        //texRECT(samplerRECT tex, float3 sz, float2 dsdx, float2 dsdy)     使用导数值查询矩形纹理，并进行深度值比较
        //texRECTproj(samplerRECT tex, float3 sq)                           矩形投影纹理查询
        //texRECTproj(samplerRECT tex, float3 szq)                          矩形投影纹理查询，并进行深度值比较

        //tex3D(sampler3D tex, float3 s)                                    查询三维纹理
        //tex3D(sampler3D tex, float3 s, float3 dsdx, float3 dsdy)          结合导数值查询三维纹理
        //tex3DDproj(sampler3D tex, float4 sq)                              查询三维投影纹理，并进行深度值比较
        #endregion
        #endregion

        #endregion

        #region 总结
        //这节课的主要目的
        //是让大家对CG语言的内置函数有一个大致了解
        //大家需要把常用函数记录到自己的笔记当中，方便之后大家查阅使用
        //也可以通过以下链接来查看更多的相关函数
        //https://learn.microsoft.com/en-us/windows/win32/direct3dhlsl/dx-graphics-hlsl-intrinsic-functions
        //这是HLSL对应的内置函数，CG和它类似（注意：不是所有函数都在Unity中被支持）
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
