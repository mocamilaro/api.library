using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;
using api.library.Repository.IRepository;
using api.library.Services.IServices;
using AutoMapper;

namespace api.library.Services
{
    public class BorrowService : IBorrowService
    {
        private readonly IBorrowRepository _BorrowRepository;
        private readonly IMapper _mapper;
        public BorrowService(IBorrowRepository BorrowRepository, IMapper mapper) 
        {
            _BorrowRepository = BorrowRepository;
            _mapper = mapper;
        }

        public Task<bool> CreateBorrowAsync(Borrows Borrow)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBorrowAsync(int id)
        {
            throw new NotImplementedException();
        }
        
        public Task<BorrowsDto> GetBorrowByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<BorrowsDto>> GetBorrowsAsync()
        {
            var Borrows = _BorrowRepository.GetBorrowsAsync(); //llamando el método desde la capa de repositorio
            
            return _mapper.Map<ICollection<BorrowsDto>>(Borrows); //mapeando la lista de Borrowas a DTOs


        }

        public Task<bool> BorrowExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> BorrowExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBorrowAsync(Borrows Borrow)
        {
            throw new NotImplementedException();
        }
    }
}
