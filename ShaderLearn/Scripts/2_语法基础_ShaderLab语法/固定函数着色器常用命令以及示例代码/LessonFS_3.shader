Shader "TeachShader/LessonFS_3" {
	Properties
	{
		_MainTex("纹理", 2D) = "white"{}
	}
	SubShader 
	{
		Pass
		{
			//将纹理应用到物体上
			SetTexture[_MainTex]
			{
				//显示纹理的原始颜色
				Combine texture
			}
		}
	}
	FallBack "Diffuse"
}