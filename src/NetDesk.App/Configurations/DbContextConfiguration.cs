using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDesk.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetDesk.App.Configurations
{
    public static class DbContextConfiguration
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NetDeskContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });
        }
    }
}
