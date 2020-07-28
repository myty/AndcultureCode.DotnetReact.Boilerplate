using AndcultureCode.CSharp.Core.Interfaces.Data;
using AndcultureCode.GB.Infrastructure.Data.SqlServer.Configuration;
using AndcultureCode.GB.Infrastructure.Data.SqlServer.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AndcultureCode.GB.Infrastructure.Data.SqlServer.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSqlServer(this IServiceCollection services, IConfigurationRoot configuration)
        {
            // Configuration
            services.AddSingleton((sp) => configuration.GetSection("DatabaseSeeds").Get<SeedsConfiguration>());

            // Repositories
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}