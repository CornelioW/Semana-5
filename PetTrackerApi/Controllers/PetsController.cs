using Microsoft.AspNetCore.Mvc;

namespace PetTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private static readonly List<string> Pets = new() { "Dog", "Cat", "Rabbit" };

        // GET: /
        [HttpGet("/")]
        public IActionResult Root()
        {
    return Ok("Welcome to the Pet Tracker API!");
}


        // POST: api/pets
        [HttpPost]
        public IActionResult AddPet([FromBody] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Pet name cannot be empty");
            }

            Pets.Add(name);
            return Ok(new { message = $"Pet {name} added!" });
        }
    }
}
