using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_6V2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.Map("/Dashboard", (newapp) => {
                newapp.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello Dashboard");
                });
            });
            
            app.Use(async (context, next) =>
            {
                var path = context.Request.Path.Value;
                if (!path.Contains("Student"))
                    await next();
                else
                    await context.Response.WriteAsync("Hollo Student");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hollo in my Application");
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
