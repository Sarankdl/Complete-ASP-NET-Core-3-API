using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;

namespace CommandAPI.Controllers
{
    [Route("api/[controllers]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        public CommandsController(ICommandAPIRepo repositoy)
        {
            _repository = repositoy;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }
    }
}