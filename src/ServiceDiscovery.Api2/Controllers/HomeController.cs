using Microsoft.AspNetCore.Mvc;
using Steeltoe.Common.Discovery;
using Steeltoe.Discovery;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServiceDiscovery.Api2.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DiscoveryHttpClientHandler _httpClientHandler;

        public HomeController(IDiscoveryClient httpClientHandler)
        {
            _httpClientHandler = new DiscoveryHttpClientHandler(httpClientHandler);
        }

        [HttpGet, Route("~/")] public async Task<IActionResult> Get()
        {
            var httpClient = new HttpClient(_httpClientHandler, false);
            var response = await httpClient.GetAsync("https://ServiceDiscoveryClient1/api/c1/home");
            var content = await response.Content.ReadAsStringAsync();
            return Ok(content);
        }
    }
}
