using AutoMapper;
using HotelPoints.API.DTOs;
using HotelPoints.API.Entities;

namespace HotelPoints.API.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
            CreateMap<Account, AccountDTO>().ReverseMap();
        }
    }
}
