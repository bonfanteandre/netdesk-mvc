using Microsoft.Extensions.DependencyInjection;
using NetDesk.Business.Interfaces.Repositories;
using NetDesk.Business.Interfaces.Services;
using NetDesk.Business.Services;
using NetDesk.Data.Repositories;

namespace NetDesk.App.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            AddRepositories(services);
            AddServices(services);
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IClientsRepository, ClientsRepository>();
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IClientsService, ClientsService>();
        }
    }
}
