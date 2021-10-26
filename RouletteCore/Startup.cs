using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RouletteCore.DataAccess;
using Roulette.DataAccess.Interfaces;
using Roulette.DataAccess.Services;
using Roulette.DataAccess.Models;
using Roulette.Security.Interfaces;
using Roulette.Security.Services;
using System.IO;

namespace RouletteCore
{
    public class Startup
    {
        IServiceCollection _services;
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddDbContext<RouletteDbContext>(options =>
            options.UseSqlServer(
            Configuration.GetConnectionString("RouletteDbContext")));
            
            _services = services;
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:4200",
                                                          "http://localhost:8888");
                                  });
            });

            // services.AddResponseCaching();
            

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
            app.UseCors(MyAllowSpecificOrigins);
            //var str = Environment.GetEnvironmentVariable("RouletteDbContext");

            //if (str == null)
            //{
            //    var configuration = new ConfigurationBuilder()
            //        .AddJsonFile("appsettings.json")
            //        .Build();
            //    str = configuration.GetConnectionString("RouletteDbContext");

            //}
            //_services.AddDbContext<RouletteDbContext>(
            //    options => options.UseSqlServer(str));

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<RouletteDbContext>();
                context.Database.Migrate();
            }
            _services.AddSingleton<IAccountServices, AccountServices>().AddEntityFrameworkSqlServer();
            _services.AddSingleton<IAccountServices, AccountServices>().AddEntityFrameworkSqlServer();
            _services.AddSingleton<IRepository<Colors>, Repository<Colors>>().AddEntityFrameworkSqlServer();
            _services.AddSingleton<IRepository<Numbers>, Repository<Numbers>>().AddEntityFrameworkSqlServer();
            _services.AddSingleton<IRepository<Logs>, Repository<Logs>>().AddEntityFrameworkSqlServer();
            _services.AddSingleton<IRepository<Users>, Repository<Users>>().AddEntityFrameworkSqlServer();
            _services.AddSingleton<IRepository<UserSessions>, Repository<UserSessions>>().AddEntityFrameworkSqlServer();
            _services.AddSingleton<IRepository<UserSessionLog>, Repository<UserSessionLog>>().AddEntityFrameworkSqlServer();
            _services.AddSingleton<IRepository<RouletteEvents>, Repository<RouletteEvents>>().AddEntityFrameworkSqlServer();
            _services.AddSingleton<IUnitOfWork, UnitOfWork>().AddEntityFrameworkSqlServer();
        }
        public void ApplyMigrations(RouletteDbContext context)
        {
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        }
    }
}
