using cw6.Models;
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
            var tests = Database.Tests;
            return Ok(tests);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tests = Database.Tests.Where(x => x.Id == id);
            return Ok(tests);
        }

        //Post api/tests { "id":4, "Name": "Test4"}
        [HttpPost]
        public IActionResult Add(Animal animal)
        {
            Database.Tests.Add(animal);
            return Created();
        }
    }
}
