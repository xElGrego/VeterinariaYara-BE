
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using veterinaria.yara.application.interfaces.repositories;
using veterinaria.yara.infrastructure.data.repositories;

namespace veterinaria.yara.infrastructure.ioc
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddScoped<IRazaRestRepository, RazaRestRepository>();
            services.AddScoped<IPersonaRestRepository, PersonaRestRepository>();
            services.AddScoped<IMascotaRestRepository, MascotaRestRepository>();

            var builderConnection = new SqlConnectionStringBuilder(configuration.GetConnectionString("DefaultConnection"));
            builderConnection.Password = "yara19975";

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builderConnection.ConnectionString);

            }, ServiceLifetime.Transient
            );

            return services;

        }
    }
}
