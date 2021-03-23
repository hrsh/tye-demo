using Microsoft.AspNetCore.Mvc;

namespace ServiceDiscovery.Api1.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet, Route("~/")] public IActionResult Get() => Ok("Client1");
    }
}
