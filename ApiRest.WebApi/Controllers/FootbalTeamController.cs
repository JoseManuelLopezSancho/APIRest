using ApiRest.Application;
using ApiRest.Entities;
using ApiRest.WebApi.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootbalTeamController : ControllerBase
    {
        IApplication<FootballTeam> _football;
        public FootbalTeamController(IApplication<FootballTeam> football)
        {
            _football = football;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_football.GetAll());
        }

        [HttpPost]
        public IActionResult Save(FootballTeamDTO dto)
        {
            var f = new FootballTeam()
            {
                Name = dto.Name,
                Score = dto.Score
            };
            return Ok(_football.Save(f));
        }
    }
}
