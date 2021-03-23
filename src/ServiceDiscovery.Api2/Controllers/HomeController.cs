using Microsoft.AspNetCore.Mvc;

namespace ServiceDiscovery.Api2.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet, Route("~/")] public IActionResult Get() => Ok("Client2");
    }
}
