.net Core+Razor+Layui

Core.Layui.HplusRazor ==>Razor 类库，勾选生成页面和视图选项
Core.Layui.Razor ==》.netStandard 类库
Core.Layui.Razor.Web ==》标准mvc项目

Startup Razor的配置：
	1、Nuget
		Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
		Microsoft.AspNetCore.Mvc.NewtonsoftJson
	2、Startup
		ConfigureServices：
			services.AddMvc().AddRazorRuntimeCompilation();
			services.AddRazorPages();
			services.AddControllersWithViews();
		Configure：
			app.UseStaticFiles(); 
