using System;

namespace ApiMongoDbExperiment.API.Domain
{
    public class MongoDbEntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
