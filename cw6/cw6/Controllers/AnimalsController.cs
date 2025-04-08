using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        // Get api/test
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
