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
              options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";   // ����Json�����ڸ�ʽ��ʾ����
                                                                                     // ���API ����ĸ�Զ���Сд����
              options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
           }).AddRazorRuntimeCompilation();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            // Dick 2021-04-12 [  ��֤֤�飬��app.UseAuthentication(); ��ȥ��֤�飬����֤�飬û���õ�֤���൱��û��֤�� ]
            services.AddAuthentication("CookieAuth").AddCookie("CookieAuth", config =>
            {
                config.Cookie.Name = "Cookie.UserLoginCode";
                config.LoginPath = "/Login/Index"; //���û��cookie��֤����ô����ת��/Login/Index ȥ��¼��֤
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
            app.UseStaticFiles(); // Dick 2021-04-21 [ ��̬�ļ���û���������Ҳ���razor�����js��css���� ]
            app.UseCookiePolicy();
            app.UseAuthentication(); //��Ȩ�������û�е�¼����¼����˭����ֵ��HttpContext.User
            app.UseAuthorization(); //��Ȩ

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
