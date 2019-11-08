using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Killrvideo.ConsolidatedHost.Facade.Models;

namespace Killrvideo.ConsolidatedHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleTestSampleController : ControllerBase
    {
        private readonly ILogger<SampleTestSampleController> _logger;

        public SampleTestSampleController(ILogger<SampleTestSampleController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public SampleTestSampleModel Get()
        {
            var pocModel = new SampleTestSampleModel("ExpectedValue");
            return pocModel;
        }
    }
}