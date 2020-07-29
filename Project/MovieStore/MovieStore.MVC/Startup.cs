using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using MovieStore.Infrastructure.Data;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Infrastructure.Repositories;
using MovieStore.Core.ServiceInterfaces;
using MovieStore.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using MovieStore.MVC.Helpers;

namespace MovieStore.MVC
{
    public class Startup
    {
        //we are going to add new things in the startup files and these are the minimum code
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllersWithViews();
            services.AddDbContext<MovieStoreDbContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("MovieStoreDbConnection")));
            //DI in ASP.NET Core has 3 types of Lifetimes
            //Scoped, Singleton, Transient
            services.AddMemoryCache();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(
                            options =>
                            {
                                options.Cookie.Name = "MovieStoreAuthCookie";
                                options.ExpireTimeSpan = TimeSpan.FromHours(2);
                                options.LoginPath = "/Account/Login";
                            }

                );
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IMovieService, MovieService>();//you can call MovieServieTest
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICryptoService, CryptoService>();
            services.AddScoped<IPurchaseRepository, PurchaseRepository>();
            services.AddScoped<IFavoriteRepository, FavoriteRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) //开发的时候
            {
                //app.UseDeveloperExceptionPage();
                app.UseMovieScoreExceptionMiddleware();
            }
            else //正常运行
            {
                app.UseExceptionHandler("/Home/Error");
            }
            //app.UseCors(builder => { 
            //    builder.WithOrigins(Configuration.GetValue<string>("clientSPAUrl")).AllowAnyHeader()
            //        .AllowAnyMethod()
            //        .AllowCredentials(); });

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //Routing--Pattern matching technique--check if it is match
                //1. Traditional way of routing
                //2. Attribute based routing
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
