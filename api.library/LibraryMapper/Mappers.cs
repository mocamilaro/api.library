using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;
using AutoMapper;

namespace api.library.LibraryMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Persons, PersonsDto>().ReverseMap();

            CreateMap<Persons, PersonsCreateDto>().ReverseMap();
        }
    }
}
