using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            return Ok("This is a message from backend");
        }
    }
}
