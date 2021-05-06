using Core.Layui.Razor.IRepository;
using Core.Layui.Razor.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Layui.Razor.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }  

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            }).AddNewtonsoftJson(options =>
           {
              options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
              options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";   // 调整Json中日期格式显示问题
                                                                                     // 解决API 首字母自动变小写问题
              options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
           }).AddRazorRuntimeCompilation();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            // Dick 2021-04-12 [  验证证书，而app.UseAuthentication(); 是去拿证书，整理证书，没有拿到证书相当于没有证书 ]
            services.AddAuthentication("CookieAuth").AddCookie("CookieAuth", config =>
            {
                config.Cookie.Name = "Cookie.UserLoginCode";
                config.LoginPath = "/Login/Index"; //如果没有cookie认证，那么就跳转到/Login/Index 去登录认证
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            string dbConn = Configuration.GetConnectionString("Default");
            services.AddScoped<IUserRepository, UserRepository>((ctx) =>{return new UserRepository(dbConn);});
            services.AddScoped<IRoleRepository, RoleRepository>((ctx) => { return new RoleRepository(dbConn); });
            services.AddScoped<IMenuRepository, MenuRepository>((ctx) => { return new MenuRepository(dbConn); });
            services.AddScoped<IUsers_RoleRepository, Users_RoleRepository>((ctx) => { return new Users_RoleRepository(dbConn); });
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseStaticFiles(); // Dick 2021-04-21 [ 静态文件，没有这句代码找不到razor里面的js和css引用 ]
            app.UseCookiePolicy();
            app.UseAuthentication(); //鉴权，检测有没有登录，登录的是谁，赋值给HttpContext.User
            app.UseAuthorization(); //授权

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                     name: "Areas",
                     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
