using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyAPIApplication.Models;

namespace MyAPIApplication.Controllers
{
    public class ProductsController : ApiController
    {
        // This would normally be a database query
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        // Returns ALL products
        // /api/products     
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        // Return A product by ID
        // /api/products/id 
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
