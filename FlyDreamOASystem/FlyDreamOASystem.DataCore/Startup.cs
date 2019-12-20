using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
namespace FlyDreamOASystem.DataCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
          
            RegisterIOC(services, "FlyDreamOASystem.DAL", "FlyDreamOASystem.BLL");
            services.AddAuthentication("Bearer")
             .AddJwtBearer("Bearer", options =>
             {
                 options.Authority = "http://localhost:9999";
                 options.RequireHttpsMetadata = false;
                 options.Audience = "DataCore";
             });
            services.AddCors(m => m.AddPolicy("Allow", builder => builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod()));
            services.AddControllers();
            //swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DataCore", Version = "v1" });
                //swagger×¢ÊÍ
                //var filePath = Path.Combine(System.AppContext.BaseDirectory, "FlyDreamOASystem.DataCore.xml");
                //c.IncludeXmlComments(filePath);
            });
        }
        public void RegisterIOC(IServiceCollection services,params string [] AssemblyList) 
        {
            foreach (var item in AssemblyList)
            {
                Assembly asm = Assembly.Load(item);
                var list = asm.GetTypes().Where(m=>m.IsClass&&!m.IsAbstract&&!(
                 m.GetCustomAttribute(typeof(Shared.NotMapAttribute),false)!=null||
                 m.GetCustomAttribute(typeof(CompilerGeneratedAttribute))!=null
                ));
                foreach (var items in list)
                {
                    if (items.GetInterfaces().Length>0) 
                    {
                        var interfaces = items.GetInterfaces().FirstOrDefault(m=>m.GetCustomAttribute(typeof(Shared.NotMapAttribute)) == null);
                        if (interfaces!=null) 
                        {
                            services.AddScoped(interfaces,items);
                        }
                    }
                }
            }
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors("Allow");
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DataCore");
            });
            app.UseAuthentication();
            app.UseAuthorization();
          
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
