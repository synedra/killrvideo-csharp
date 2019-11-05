using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Killrvideo.ConsolidatedHost.Tests.Controllers
{
    public class ProofOfConcept
    {
        public ProofOfConcept()
        {
            ApiUri = "https://localhost:5000";
        }

        public string ApiUri { get; set; }

        [Fact]
        public async Task GetProofOfConceptGet()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            var apiClient = new HttpClient(clientHandler);
            var apiResponse = await apiClient.GetAsync($"{ApiUri}/proofofconcept");
            Assert.True(apiResponse.IsSuccessStatusCode);
        }
    }
}