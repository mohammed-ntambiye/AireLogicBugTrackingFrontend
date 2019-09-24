using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AireLogicBugTrackingFrontend.Gateways;
using AireLogicBugTrackingFrontend.Gateways.Interfaces;
using AireLogicBugTrackingFrontend.Services;
using AireLogicBugTrackingFrontend.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AireLogicBugTrackingFrontend
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

            services.AddTransient<IBugsService, BugsService>();
            services.AddTransient<IBugsGateway, BugsGateway>();

            services.AddTransient<IAccountsService, AccountsService>();
            services.AddTransient<IAccountsGateway, AccountsGateway>();


            services.Configure<Configuration.Configuration>(Configuration.GetSection("Configuration"));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Bugs}/{action=Index}/{id?}");
                routes.MapRoute("Bugs", "{controller=Bugs}/{action=Index}/{id?}");
            });
        }
    }
}
