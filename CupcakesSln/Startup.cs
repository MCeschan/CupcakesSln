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
using CupcakesSln.Data;
using CupcakesSln.Repositories;

namespace CupcakesSln
{

    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddTransient<ICupcakeRepository, CupcakeRepository>();
            services.AddDbContext<CupcakeContext>(options =>
                  options.UseSqlServer(_configuration.GetConnectionString("KeyDB")));

            services.AddMvc();
        }

        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(IApplicationBuilder app, CupcakeContext cupcakeContext)
        {
            //cupcakeContext.Database.EnsureDeleted();
            //cupcakeContext.Database.EnsureCreated();

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                _ = routes.MapRoute(
                    name: "CupcakeRoute",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Cupcake", action = "Index" },
                    constraints: new { id = "[0-9]+" });
            });
        }
    }
}