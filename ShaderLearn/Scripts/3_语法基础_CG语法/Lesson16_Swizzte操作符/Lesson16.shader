Shader "TeachShader/Lesson16"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
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

                // 利用swuzzle来提取分量
                fixed4 f4 = fixed4(1,2,3,4);
                fixed f = f4.x; // xyzw
                f = f4.a; // rgba
                // 利用他来重新排列分量
                f4 = f4.yzxw;
                f4 = f4.abgr;

                // 利用它来创建新的向量
                fixed3 f3 = f4.xyz;
                fixed2 f2 = f4.xz;
                fixed4 f4_2 = fixed4(f2,8,9);
                f4_2 = fixed4(f3,9);

                fixed4x4 f4x4 = {
                                 1,2,3,4,
                                 2,4,6,8,
                                 5,6,7,8,
                                 f4
                                };
                fixed f1 = f4x4[0][1];
                f4_2 = f4x4[0];
                fixed3 f3_2 = f4;

                fixed3x3 f3x3 = {
                                 1,2,3,
                                 2,4,6,
                                 5,6,7,};
                fixed4x4 f4x4_2 = {
                        f3x3[0][0],f3x3[0][1],f3x3[0][2],3,
                        f3x3[1][0],f3x3[1][1],f3x3[1][2],3,
                        f3x3[2][0],f3x3[2][1],f3x3[2][2],3,
                        7,8,9,10
                };
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