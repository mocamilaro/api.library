using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;
using api.library.Repository.IRepository;
using api.library.Services.IServices;
using AutoMapper;

namespace api.library.Services
{
    public class CopyService : ICopyService
    {
        private readonly ICopyRepository _CopyRepository;
        private readonly IMapper _mapper;
        public CopyService(ICopyRepository CopyRepository, IMapper mapper) 
        {
            _CopyRepository = CopyRepository;
            _mapper = mapper;
        }

        public Task<bool> CreateCopyAsync(Copies Copy)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCopyAsync(int id)
        {
            throw new NotImplementedException();
        }
        
        public Task<CopiesDto> GetCopyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CopiesDto>> GetCopysAsync()
        {
            var Copys = _CopyRepository.GetCopiesAsync(); //llamando el método desde la capa de repositorio
            
            return _mapper.Map<ICollection<CopiesDto>>(Copys); //mapeando la lista de Copyas a DTOs


        }

        public Task<bool> CopyExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCopyAsync(Copies Copy)
        {
            throw new NotImplementedException();
        }

        Task<ICollection<CopiesDto>> ICopyService.GetCopiesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
