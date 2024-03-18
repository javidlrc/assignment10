using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mission10.Data;

namespace mission10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingLeagueController(IBowlingRepository temp) {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var bowlingData = _bowlingRepository.GetBowlers();

            return bowlingData;
        }

        

    }
}
