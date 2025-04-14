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
        
        
        // Put api/animals/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id,Animal updatedAnimal)
        {
            var existingAnimal = Database.Tests.FirstOrDefault(x => x.Id == id);
            if (existingAnimal == null)
            {
                return NotFound();
            }
            existingAnimal.Name = updatedAnimal.Name;
            existingAnimal.Kategoria = updatedAnimal.Kategoria;
            existingAnimal.Masa = updatedAnimal.Masa;
            existingAnimal.kolorSiersci = updatedAnimal.kolorSiersci;

            return NoContent();
        }
        
        // Delete api/animals/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var animal = Database.Tests.FirstOrDefault(x => x.Id == id);
            if (animal == null)
            {
                return NotFound();
            }

            Database.Tests.Remove(animal);
            return NoContent();
        }
        
        
        // Get api/animals/search/{name}
        [HttpGet("search/{name}")]
        public IActionResult SearchByName(string name)
        {
            var animals = Database.Tests.Where(x => x.Name.Contains(name)).ToList();
            return Ok(animals);
        }
        
        [HttpGet("{id}/visits")]
        public IActionResult GetVisits(int id)
        {
            var animal = Database.Tests.FirstOrDefault(a => a.Id == id);
            if (animal == null)
                return NotFound();

            var animalVisits = Database.TestVisits.Where(v => v.Animal.Id == id).ToList();
            return Ok(animalVisits);
        }
    }
}
