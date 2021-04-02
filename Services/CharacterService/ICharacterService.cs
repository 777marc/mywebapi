using System.Collections.Generic;
using System.Threading.Tasks;
using mywebapi.Models;

namespace mywebapi.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character character);
    }
}