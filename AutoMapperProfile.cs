using AutoMapper;
using mywebapi.Dtos.Character;
using mywebapi.Models;

namespace mywebapi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}