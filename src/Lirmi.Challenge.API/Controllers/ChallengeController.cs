using Lirmi.Challenge.API.Models;
using Lirmi.Challenge.API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lirmi.Challenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengeController : ControllerBase
    {
        private IChallengeService _colegioService;

        public ChallengeController(IChallengeService colegioService)
        {
            _colegioService = colegioService;
        }
        
        // GET: api/<ColegioController>
        [HttpGet]
        public IEnumerable<ChallengeDTO> Get()
        {
            return _colegioService.GetChallengeData();
        }

       
    }
}
