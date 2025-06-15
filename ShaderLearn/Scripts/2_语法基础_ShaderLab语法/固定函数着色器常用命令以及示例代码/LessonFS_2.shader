Shader "TeachShader/LessonFS_2" {
	Properties 
	{
		_Color("漫反射颜色", Color)=(1,1,1,1)
	}
	SubShader 
	{
		Pass
		{
			//开启光照
			Lighting on
			//使用Material命令
			Material
			{
				//设置漫反射光照颜色
				Diffuse[_Color]
			}
		}
	}
	FallBack "Diffuse"
}