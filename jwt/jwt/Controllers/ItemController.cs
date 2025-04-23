using jwt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace jwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        
        private static List<Item> items = new List<Item>
        {
            new Item { Id = 1, Title = "Item 1", Description = "First item" },
            new Item { Id = 2, Title = "Item 2", Description = "Second item" }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create(Item newItem)
        {
            if (string.IsNullOrWhiteSpace(newItem.Title))
                return BadRequest("Title is required.");

            newItem.Id = items.Max(i => i.Id) + 1;
            items.Add(newItem);

            return CreatedAtAction(nameof(GetById), new { id = newItem.Id }, newItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Item updatedItem)
        {
            if (string.IsNullOrWhiteSpace(updatedItem.Title))
                return BadRequest("Title is required.");

            var existingItem = items.FirstOrDefault(i => i.Id == id);
            if (existingItem == null)
                return NotFound();

            existingItem.Title = updatedItem.Title;
            existingItem.Description = updatedItem.Description;

            return NoContent(); 
        }
    }
}
