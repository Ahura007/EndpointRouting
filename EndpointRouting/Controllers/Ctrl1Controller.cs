using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EndpointRouting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ctrl1Controller : ControllerBase
    {
        private readonly ILogger<Ctrl1Controller> _logger;

        public Ctrl1Controller(ILogger<Ctrl1Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(string temp, int number = 0)
        {
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync(TestModel model)
        {
            return Ok();
        }

        public class TestModel
        {
            public string Sample { get; set; }
        }
    }
}