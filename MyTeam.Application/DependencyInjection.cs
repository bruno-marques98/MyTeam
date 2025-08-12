using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MyTeam.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // AutoMapper scanning this assembly
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
