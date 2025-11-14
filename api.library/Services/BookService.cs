using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;
using api.library.Repository.IRepository;
using api.library.Services.IServices;
using AutoMapper;

namespace api.library.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _BookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepository BookRepository, IMapper mapper) 
        {
            _BookRepository = BookRepository;
            _mapper = mapper;
        }

        public Task<bool> CreateBookAsync(Books Book)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBookAsync(int id)
        {
            throw new NotImplementedException();
        }
        
        public Task<BooksDto> GetBookByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<BooksDto>> GetBooksAsync()
        {
            var Books = _BookRepository.GetBooksAsync(); //llamando el método desde la capa de repositorio
            
            return _mapper.Map<ICollection<BooksDto>>(Books); //mapeando la lista de Bookas a DTOs


        }

        public Task<bool> BookExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> BookExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBookAsync(Books Book)
        {
            throw new NotImplementedException();
        }
    }
}
