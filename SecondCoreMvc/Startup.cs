using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SecondCoreMvc.Models;
using SecondCoreMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCoreMvc
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
        //    services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped<ICalculator, Calculator18>();
            var connection = @"Server=(localdb)\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True";
            services.AddDbContext<SchoolContext>(options => options.UseSqlServer(connection));
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(configureRoutes);
            
           
        }

        private void configureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("default", "{controller=Employee}/{action=Add}/{id?}");
           
        }
    }
}
