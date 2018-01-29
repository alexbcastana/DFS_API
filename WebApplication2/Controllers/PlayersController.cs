using WebApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class PlayersController : ApiController
    {
        Player[] products = new Player[]
        {
            new Player { Id = 1, FName = "Lebron", LName = "James", Salary = 3000 },
            new Player { Id = 2, FName = "Lonzo", LName = "Ball", Salary = 1000 },
            new Player { Id = 3, FName = "Kyrie", LName = "Irving", Salary = 2000 }
        };

        public IEnumerable<Player> GetAllProducts()
        {
            return products;
        }

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