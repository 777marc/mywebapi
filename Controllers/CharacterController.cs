using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mywebapi.Dtos.Character;
using mywebapi.Models;
using mywebapi.Services.CharacterService;

namespace mywebapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDto character)
        {
            return Ok(await _characterService.AddCharacter(character));
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateCharacter([FromBody]AddCharacterDto character)
        {
            return Ok(await _characterService.UpdateCharacter(character));
        }
    }
}