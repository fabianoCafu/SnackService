using ApiSnackService.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SnackService.Api.Context;
using SnackService.Api.Extensions;
using SnackService.Api.Integracao.Interface;
using SnackService.Api.Integracao.NovaPasta;
using SnackService.Api.Service;
using SnackService.Api.Service.Interface;
using SnackService.Api.Services;
using SnackService.Api.Services.interfaces;
using SnackService.Api.Util;

namespace SnackService.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("AppConnection")));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SnackService.Api", Version = "v1" });
            });

            services.AddGlobalExceptionHandlerMiddleware();

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            services.AddScoped<IViaCepClient, ViaCepClientSevice>();
            services.AddScoped<ICustomerService, CustomerService>();

            services.AddScoped<IOrderedService, OrderedService>();
            services.AddScoped<IDeliverymanService, DeliverymanService>();
            //services.AddScoped<IAdditionalService, AdditionalService>();
        }

        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SnackService.Api v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseGlobalExceptionHandlerMiddleware();
        }
    }
}
