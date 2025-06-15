 Shader "TeachShader/Lesson4"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        //  _Name("Display Name", type) = defaultValue[{options}]

        //数值类型有三种：
        //1.整形
        //_Name("Display Name", Int) = number
        //2.浮点型
        //_Name("Display Name", Float) = number
        //3.范围浮点型
        //_Name("Display Name", Range(min,max)) = number
        _MyInt("MyInt", Int) = 1
        _MyFloat("MyFloat", Float) = 0.5
        _MyRange("MyRange", Range(1, 2)) = 1.5

        //1.颜色
        //_Name("Display Name", Color) = (number1,number2,number3,number4)
        //注意：颜色值中的RGBA的取值范围是 0~1 （映射0~255）
        //2.向量
        //_Name("Display Name", Vector) = (number1,number2,number3,number4)
        //注意：向量值中的XYZW的取值范围没有限制
        _MyColor("MyColor", Color) = (0.5, 0.5, 0.5, 1)
        _MyVector("MyVector", Vector) = (1, 2, 3, 1)

        //纹理贴图类型有四种
        //1.2D 纹理（最常用的纹理，漫反射贴图、法线贴图都属于2D纹理）
        //_Name("Display Name", 2D) = "defaulttexture"{}

        //2.2DArray 纹理（纹理数组，允许在纹理中存储多层图像数据，每层看做一个2D图像，一般使用脚本创建，较少使用，了解即可）
        //_Name("Display Name", 2DArray) = "defaulttexture"{}

        //3.Cube map texture纹理（立方体纹理，由前后左右上下6张有联系的2D贴图拼成的立方体，比如天空盒和反射探针）
        //_Name("Display Name", Cube) = "defaulttexture"{}

        //4.3D纹理（一般使用脚本创建，极少使用，了解即可）
        //_Name("Display Name", 3D) = "defaulttexture"{}

        //注意：
        //1.关于defaulttexture默认值取值
        //  不写:默认贴图为空
        //  white:默认白色贴图（RGBA:1,1,1,1）
        //  black:默认黑色贴图（RGBA:0,0,0,1）
        //  gray:默认灰色贴图（RGBA:0.5,0.5,0.5,1）
        //  bump:默认凸贴图（RGBA:0.5,0.5,1,1）,一般用于法线贴图默认贴图
        //  red：默认红色贴图（RGBA:1,0,0,1）

        //2.关于默认值后面的 {} ,固定写法（老版本中括号内可以控制固定函数纹理坐标的生成，但是新版本中没有该功能了）

        _My2D("My2D", 2D) = "white"{}
        _MyCube("MyCube", Cube) = ""{}
        // 不常用
        _My2DArray("My2DArray", 2DArray) = ""{}
        _My3D("My3D", 3D) = ""{}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}