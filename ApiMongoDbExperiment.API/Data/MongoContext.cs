using ApiMongoDbExperiment.API.Configurations;
using ApiMongoDbExperiment.API.Constants;
using ApiMongoDbExperiment.API.Domain;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ApiMongoDbExperiment.API.Data
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;

        public MongoContext(IOptions<MongoOptions> mongoOptions)
        {
            var client = new MongoClient(mongoOptions.Value.Connection);
            _database = client.GetDatabase(mongoOptions.Value.Database);
        }

        public IMongoCollection<Team> Teams => _database.GetCollection<Team>(Collections.Team);

    }
}
