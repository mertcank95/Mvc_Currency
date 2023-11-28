using AutoMapper;
using Currency.Entities.Dtos;
using Currency.Entities.EntityModels;

namespace CurrencyApp.Helper.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationDto, User>();
        }
    }


}
