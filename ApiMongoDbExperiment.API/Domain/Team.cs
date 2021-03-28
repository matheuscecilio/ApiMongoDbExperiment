using System.Collections.Generic;

namespace ApiMongoDbExperiment.API.Domain
{
    public class Team : MongoDbEntityBase
    {
        public string Name { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}
