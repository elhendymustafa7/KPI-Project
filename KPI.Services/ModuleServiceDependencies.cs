using KPI.Infrastructure.Repositories;
using KPI.Services.Abstracts;
using KPI.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace KPI.Services
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IKPIService, KPIService>();
            return services;
        }
    }
}
