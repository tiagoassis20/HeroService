using HeroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HeroService.Controllers
{
    public class HeroesController : ApiController
    {
        Hero[] heroes = new Hero[]
        {
            new Hero () { Id =  0,  Name =  "Zero" },
            new Hero () { Id =  11, Name =  "Mr. Nice" },
            new Hero () { Id =  12, Name =  "Narco" },
            new Hero () { Id =  13, Name =  "Bombasto" },
            new Hero () { Id =  14, Name =  "Celeritas" },
            new Hero () { Id =  15, Name =  "Magneta" },
            new Hero () { Id =  16, Name =  "RubberMan" },
            new Hero () { Id =  17, Name =  "Dynama" },
            new Hero () { Id =  18, Name =  "Dr IQ" },
            new Hero () { Id =  19, Name =  "Magma" },
            new Hero () { Id =  20, Name =  "Tornado" }
        };

        public IEnumerable<Hero> GetHeroes()
        {
            return heroes;
        }
        public IHttpActionResult GetHero(int id)
        {
            var hero = heroes.FirstOrDefault(p => p.Id == id);
            if (hero == null)
                return NotFound();
            return Ok(hero);
        }
    }
}
