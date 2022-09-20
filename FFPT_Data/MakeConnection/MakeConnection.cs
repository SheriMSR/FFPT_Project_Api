﻿using FFPT_Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FFPT_Data.MakeConnection
{
    public static class MakeConnection
    {
        public static IServiceCollection ConnectToConnectionString(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FFPTProjectDBContext>(options =>
            {
                options.UseLazyLoadingProxies();
                options.UseSqlServer(configuration.GetConnectionString("SQLServerDatabase"), sql => sql.UseNetTopologySuite());
            });
            return services;
        }
    }
}