using ApiMongoDbExperiment.API.Data;
using ApiMongoDbExperiment.API.Domain;
using ApiMongoDbExperiment.API.Interfaces;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongoDbExperiment.API.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly MongoContext _context;

        public TeamRepository(MongoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Team>> GetAllAsync()
            => await _context.Teams
                .AsQueryable()
                .ToListAsync();

        public async Task<Team> GetByIdAsync(Guid id)
            => await _context.Teams
                .AsQueryable()
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task InsertAsync(Team team)
            => await _context.Teams.InsertOneAsync(team);
    }
}
