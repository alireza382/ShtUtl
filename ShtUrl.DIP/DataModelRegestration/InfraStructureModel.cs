using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using ShtUrl.Data.Context;

namespace ShtUrl.DIP.DataModelRegestration
{
    public static class InfraStructureModel
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShoorteenUrlDbContext>(options =>

            options.UseSqlServer(configuration.GetConnectionString("ShorteenUrlDB"))

            );
            return services;
        }

        
    }
}
