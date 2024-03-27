using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using SAPPHIRE.PONY.Domain.Catalog;

namespace SAPPHIRE.PONY.Api.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase{
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new[]
            {
                new Item(Name: "Item 1", Description: "Description 1", Brand: "Brand 1", price: 100.00m),
                new Item(Name: "Item 2", Description: "Description 2", Brand: "Brand 2", price: 200.00m),
                new Item(Name: "Item 3", Description: "Description 3", Brand: "Brand 3", price: 300.00m),
                new Item(Name: "Item 4", Description: "Description 4", Brand: "Brand 4", price: 400.00m),
                new Item(Name: "Item 5", Description: "Description 5", Brand: "Brand 5", price: 500.00m)
            };
            return Ok(items);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id) {
            var item = new Item("Item 1", "Description 1", "Brand 1", 100.00m) {
                Id = id
            };

            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateItem (Item item) {
            return CreatedAtAction(nameof(GetItem), new { id = 42 }, item);
        }
    }
}

