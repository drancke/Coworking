using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Config
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            //var basepath = AppDomain.CurrentDomain.BaseDirectory;
            //var xmlPath = Path.Combine(basepath, "Coworking.Api.xml");

            services.AddSwaggerGen(option => {
                option.SwaggerDoc("v1", new OpenApiInfo { Title = "Coworking API V1", Version = "v1" });
                //option.IncludeXmlComments(xmlPath);


            });
          

            return services;
        }


        public static IApplicationBuilder addRegisterMiddleware(this IApplicationBuilder applicationBuilder)
        {

            applicationBuilder.UseSwagger();
            applicationBuilder.UseSwaggerUI(option => {
                option.SwaggerEndpoint("/swagger/v1/swagger.json", "Coworking API V1");
            });

            return applicationBuilder;
        } 
    }
}
