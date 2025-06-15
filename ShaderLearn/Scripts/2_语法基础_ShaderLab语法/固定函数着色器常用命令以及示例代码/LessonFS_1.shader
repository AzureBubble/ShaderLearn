Shader "TeachShader/LessonFS_1"
{
	Properties 
	{
		_Color("颜色", Color)=(1,1,1,1)
	}
	SubShader 
	{
		Pass
		{
			//关闭光照
			Lighting off
			//渲染颜色
			//Color(1,1,0,1)
			//利用属性参数设置颜色
			Color[_Color]
		}
	}
	FallBack "Diffuse"
}