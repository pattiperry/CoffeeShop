using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;
using CoffeeShop.Repositories;

namespace CoffeeShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeVarietyController : ControllerBase
    {
        private readonly ICoffeeVarietyRepository _coffeeVarietyRepository;
        public CoffeeVarietyController(ICoffeeVarietyRepository coffeeVarietyRepository)
        {
            _coffeeVarietyRepository = coffeeVarietyRepository;
        }

        // https://localhost:5001/api/coffeevariety/
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_coffeeVarietyRepository.GetAll());
        }

        // https://localhost:5001/api/coffeevariety/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var variety = _coffeeVarietyRepository.Get(id);
            if (variety == null)
            {
                return NotFound();
            }
            return Ok(variety);
        }

        // https://localhost:5001/api/coffeevariety/
        [HttpPost]
        public IActionResult Post(CoffeeVariety coffeeVariety)
        {
            _coffeeVarietyRepository.Add(coffeeVariety);
            return CreatedAtAction("Get", new { id = coffeeVariety.Id }, coffeeVariety);
        }

        // https://localhost:5001/api/coffeevariety/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, CoffeeVariety coffeeVariety)
        {
            if (id != coffeeVariety.Id)
            {
                return BadRequest();
            }

            _coffeeVarietyRepository.Update(coffeeVariety);
            return NoContent();
        }

        // https://localhost:5001/api/coffeevariety/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _coffeeVarietyRepository.Delete(id);
            return NoContent();
        }
    }
}

