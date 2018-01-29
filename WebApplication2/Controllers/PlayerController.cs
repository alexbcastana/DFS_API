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
        Player[] players = new Player[]
        {
            new Player { Id = 1, FName = "Mark", LName = "Ingram", Salary = 1000 },
            new Player { Id = 2, FName = "Juju", LName = "Smith-Schuster", Salary = 1000 },
            new Player { Id = 3, FName = "T.Y.", LName = "Hilton", Salary = 3000 }
        };

        public IEnumerable<Player> GetAllPlayers()
        {
            return players;
        }

        public IHttpActionResult GetPlayer(int id)
        {
            var player = players.FirstOrDefault((p) => p.Id == id);
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }
    }
}