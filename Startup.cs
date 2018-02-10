using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PieShopCore.Data;
using PieShopCore.IRepositories;
using PieShopCore.IServices;
using PieShopCore.Repositories;
using PieShopCore.Services;

namespace PieShopCore
{
    public class Startup
    {

        public IConfiguration Configuration { get; }


        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //AppDbContext
            services.AddDbContext<AppDbContext>(options => options
            .UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            //Repositories
            //services.AddTransient<IPieRepository, MockPieRepository>();
            services.AddTransient<IPieRepository, PieRepository>();


            //Services
            services.AddTransient<IPieService, PieService>();


            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
