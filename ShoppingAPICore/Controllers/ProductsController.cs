using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingAPICore.Models;

namespace ShoppingAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        Product[] products = new Product[]
        {
            new Product {Id = 1, Category = "IT Stuff", Name = "Keyboard", Price = 10.99M},
            new Product {Id = 2, Category = "Books", Name = "Book1", Price = 1.99M},
            new Product {Id = 3, Category = "DVDs", Name = "Jurassic Park", Price = 2M}
        };


        // GET api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

    }
}