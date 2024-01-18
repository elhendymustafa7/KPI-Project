global using Microsoft.Extensions.DependencyInjection;
using KPI.Infrastructure.Abstracts;
using KPI.Infrastructure.Repositories;

namespace KPI.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IKPIRepository, KPIRepository>();
            return services;
        }
    }
}
