Shader "TeachShader/LessonFS_4" {
	Properties 
	{
		_DiffuseColor("漫反射颜色", Color)=(1,1,1,1)
		_MainTex("纹理", 2D) = "white"{}
	}
	SubShader 
	{
		Pass
		{
			//开启灯光
			Lighting on 
			//使用Material命令
			Material
			{
				//设置漫反射光照颜色
				Diffuse[_DiffuseColor]
			}
			//受到纹理的影响
			SetTexture[_MainTex]
			{
				// 将之前灯光计算出来的颜色 与 texture相乘才能受到灯光影响
				Combine texture * primary DOUBLE
			}
		}
	}
	FallBack "Diffuse"
}