Shader "TeachShader/Lesson8"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags {
            "RenderType"="Opaque"
            "Queue"="Transparent-1"
            //"DisableBatching"="True"
            //"DisableBatching" = "LODFading"
            //"ForceNoShadowCasting" = "True"
            //"IgnoreProjector" = "True"
            //"CanUseSpriteAtlas" = "False"
        }
        LOD 100
        Cull Off
        //ZWrite Off
        //ZTest Greater
        //Blend One One

        // 在其他shader中服用该Pass代码时
        UsePass "TeachShader/Lesson8/MYLESSON8PASS"

        Pass
        {
            //  1.Name 名称
            Name "MyLesson8Pass"
            //  2.渲染标签
            //  3.渲染状态
            //  4.其他着色器代码
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