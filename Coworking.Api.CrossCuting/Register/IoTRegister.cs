using Coworking.Api.Aplication.Configuration;
using Coworking.Api.Aplication.Services;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.DataAccess;
using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Coworking.Api.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.CrossCuting.Register
{
   public static class IoTRegister
    {

        public static IServiceCollection AddRegistration(IServiceCollection services)
        {
            AddRegisterService(services);
            AddRegisterRepositories(services);
            AddRegisterOther(services);

            return services;
        }

        public static IServiceCollection AddRegisterService(IServiceCollection services)
        {
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<IBookingService, BookingService>();   
            services.AddTransient<IAdminService, AdminService>();   
            services.AddTransient<IOfficeService, OfficeService>();   
            services.AddTransient<IUserService, UserService>();   
            services.AddTransient<IServicesService, ServicesService>();   
            services.AddTransient<IRoomService, RoomService>();   
            
            return services;
        }

        public static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<ICoworkingDbContext, CoworkingDbContext>();
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IBookingRepository, BookingRepository>();
            services.AddTransient<IOfficeRepository, OfficeRepository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }

        public static IServiceCollection AddRegisterOther(IServiceCollection services)
        {
            services.AddTransient<IAppConfig, AppConfig>();
      

            return services;
        }
    }
}
