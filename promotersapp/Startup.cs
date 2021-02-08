using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using promotersapp.Contexts;
using promotersapp.Repositories;
using AutoMapper;
using promotersapp.Services;

namespace promotersapp
{
   
    public class Startup
    {
        //private static UserDbContext _dbContext;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //_dbContext = dbContext;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Database connection string.
            // TODO move in configuration file
            var connection = @"Server=127.0.0.1,1433;Database=Promoter_DB_TEST;User=sa;Password=sql67ServerPassword;";

            services.AddDbContext<PromoterDbContext>(options => options.UseSqlServer(connection));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IPromoterService, PromoterService>();
            services.AddScoped<IAccountService, AccountService>();

            services.AddControllersWithViews();
           
            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                //{
                //    HotModuleReplacement = true
                //});
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}