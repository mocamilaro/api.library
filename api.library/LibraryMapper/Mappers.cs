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

            CreateMap<Books, BooksDto>().ReverseMap();

            CreateMap<Books, BooksCreateDto>().ReverseMap();

            CreateMap<Borrows, BorrowsDto>().ReverseMap();

            CreateMap<Borrows, BorrowsCreateDto>().ReverseMap();

            CreateMap<Copies, CopiesDto>().ReverseMap();

            CreateMap<Copies, CopiesCreateDto>().ReverseMap();

            CreateMap<Details, DetailsDto>().ReverseMap();

            CreateMap<Details, DetailsCreateDto>().ReverseMap();

            CreateMap<Users, UsersDto>().ReverseMap();

            CreateMap<Users, UsersCreateDto>().ReverseMap();
        }
    }
}
