using ApiMongoDbExperiment.API.Data;
using ApiMongoDbExperiment.API.Interfaces;
using ApiMongoDbExperiment.API.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiMongoDbExperiment.API.Configurations
{
    public static class MongoInstaller
    {
        public static void InstalarMongo(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            var connectionString = configuration.GetSection("MongoDb:ConnectionString").Value;
            var database = configuration.GetSection("MongoDb:Database").Value;

            services.Configure<MongoOptions>(config =>
            {
                config.Connection = connectionString;
                config.Database = database;
            });

            services.AddScoped<MongoContext>();
            services.AddScoped<ITeamRepository, TeamRepository>();
        }
    }
}
