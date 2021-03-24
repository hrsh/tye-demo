using Microsoft.AspNetCore.Mvc;

namespace ServiceDiscovery.Api1.Controllers
{
    [ApiController]
    [Route("api/c1/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet] public IActionResult Get() => Ok("Client1");
    }
}
