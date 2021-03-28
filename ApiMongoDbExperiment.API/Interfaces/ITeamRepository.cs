using ApiMongoDbExperiment.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiMongoDbExperiment.API.Interfaces
{
    public interface ITeamRepository
    {
        Task InsertAsync(Team team);

        Task<Team> GetByIdAsync(Guid id);

        Task<IEnumerable<Team>> GetAllAsync();
    }
}
