using Killrvideo.ConsolidatedHost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Killrvideo.ConsolidatedHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProofOfConceptController : ControllerBase
    {
        private readonly ILogger<ProofOfConceptController> _logger;

        public ProofOfConceptController(ILogger<ProofOfConceptController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public ProofOfConceptModel Get()
        {
            var pocModel = new ProofOfConceptModel("ExpectedValue");
            return pocModel;
        }
    }
}