using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using mywebapi.Models;

namespace mywebapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Name = "Sam" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(characters);
        }

    }
}