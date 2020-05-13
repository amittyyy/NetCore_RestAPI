using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NetCoreRestApi.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NetCoreRestApi.Services;
using Microsoft.OpenApi.Models;

namespace NetCoreRestApi
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
            services.AddControllers();
            //services.AddDbContext<ProductDbContext>(option => option.UseSqlServer(@"Data Source=(local);Initial Catalog=NetCoreRestApi;Integrated Security=True"));

            //Auzre Service ConnectionString
            services.AddDbContext<ProductDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("ProductDbContext")));

           // services.AddApiVersioning();
            services.AddScoped<IProduct, ProductRepository>();

            // add swagger Doc
            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "Product Api", Version = "v1" }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ProductDbContext productsDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            //URL:- https://localhost:5001/swagger/index.html

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API Products");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            productsDbContext.Database.EnsureCreated();

            //app.UseSwagger();
            //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "APi for Products"));
        }
    }
}
