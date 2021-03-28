using ApiMongoDbExperiment.API.Domain;
using ApiMongoDbExperiment.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiMongoDbExperiment.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ILogger<TeamController> _logger;
        private readonly ITeamRepository _repository;

        public TeamController(
            ILogger<TeamController> logger, 
            ITeamRepository repository
        )
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Team>> GetAllAsync()
            => await _repository.GetAllAsync();

        [HttpGet, Route("/{id:guid}")]
        public async Task<Team> GetByIdAsync(Guid id)
            => await _repository.GetByIdAsync(id);

        [HttpPost]
        public async Task InsertAsync([FromBody] Team team)
            => await _repository.InsertAsync(team);
    }
}
