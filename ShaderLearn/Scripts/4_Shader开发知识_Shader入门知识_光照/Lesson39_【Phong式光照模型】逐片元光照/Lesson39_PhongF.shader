Shader "Lesson/Lesson39_PhongF"
{
    Properties
    {
        _MainColor ("MainColor", Color) = (1,1,1,1)
        _SpecularColor ("SpecularColor", Color) = (1,1,1,1)
        _SpecularNum ("SpecularNum", Range(0, 20)) = 0.5
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

            #include "UnityCG.cginc"
            #include "Lighting.cginc"

            fixed4 _MainColor;
            fixed4 _SpecularColor;
            float _SpecularNum;

            struct v2f
            {
                float4 pos : SV_POSITION;
                float3 wNormal : NORMAL;
                float3 wPos : TEXCOORD0;
            };

            v2f vert (appdata_base v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);

                // 法线
                o.wNormal = UnityObjectToWorldNormal(v.normal);
                o.wPos = mul(unity_ObjectToWorld, v.vertex).xyz;
                return o;
            }

            fixed3 GetLambertColor(in float3 wNormal)
            {
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                fixed3 color = _LightColor0.rgb * _MainColor.rgb * max(0, dot(lightDir, wNormal));
                return color;
            }

            fixed3 GetPhongColor(in float3 wNormal, in float3 wPos)
            {
                float3 viewDir = normalize(_WorldSpaceCameraPos.xyz - wPos);
                float3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                float3 reflectDir = reflect(-lightDir, wNormal);
                fixed3 color = _LightColor0.rgb * _SpecularColor.rgb * pow(max(0, dot(reflectDir, viewDir)), _SpecularNum);
                return color;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed3 lambertColor = GetLambertColor(i.wNormal);
                fixed3 PhongColor = GetPhongColor(i.wNormal, i.wPos);
                fixed3 color = UNITY_LIGHTMODEL_AMBIENT.rgb + lambertColor + PhongColor;
                return fixed4(color.rgb, 1);
            }
            ENDCG
        }
    }
}