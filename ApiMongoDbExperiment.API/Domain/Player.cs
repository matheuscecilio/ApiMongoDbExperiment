using ApiMongoDbExperiment.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongoDbExperiment.API.Domain
{
    public class Player : MongoDbEntityBase
    {
        public string Name { get; set; }
        public Position Position { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
