using System.Collections.Generic;
using System.Threading.Tasks;
using mywebapi.Dtos.Character;
using mywebapi.Models;

namespace mywebapi.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto character);

        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto character);
    }
}