using Microsoft.Extensions.DependencyInjection;
using NetDesk.Business.Interfaces.Repositories;
using NetDesk.Business.Interfaces.Services;
using NetDesk.Business.Interfaces.UnitOfWork;
using NetDesk.Business.Services;
using NetDesk.Data.Repositories;
using NetDesk.Data.UnitOfWork;

namespace NetDesk.App.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            AddRepositories(services);
            AddServices(services);
            AddUnitOfWork(services);
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IClientsRepository, ClientsRepository>();
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IClientsService, ClientsService>();
        }

        private static void AddUnitOfWork(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
