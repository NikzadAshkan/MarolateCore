using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MarolateCore.Application.Security;
using MarolateCore.Infrastructure.Security;
using MarolateCore.Application.Logging;
using MarolateCore.Infrastructure.Logging;
using MarolateCore.Application.Validation;
using MarolateCore.Infrastructure.Validation;




namespace MarolateCore.Infrastructure.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Repository registrations

            // Service registrations
            // Authentication & Authorization
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IRoleService, RoleService>();
            // Logging
            services.AddSingleton<ILogService, LogService>();
            // Validation
            services.AddScoped(typeof(IValidator<>), typeof(ValidationService<>));

            // Integration services
            // External services



            return services;
        }
    }
}
