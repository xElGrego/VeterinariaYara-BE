using Microsoft.Extensions.DependencyInjection;
using veterinaria.yara.application.interfaces.services;
using veterinaria.yara.application.services;

namespace veterinaria.yara.application.ioc
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IRazaRepository, InfoRazaRepository>();
            services.AddScoped<IPersonaRepository, InfoPersonaRepository>();
            services.AddScoped<IMascotaRepository, InfoMascotaRepository>();
            return services;
        }
    }
}
