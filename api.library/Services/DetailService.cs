using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;
using api.library.Repository.IRepository;
using api.library.Services.IServices;
using AutoMapper;

namespace api.library.Services
{
    public class DetailService : IDetailService
    {
        private readonly IDetailRepository _DetailRepository;
        private readonly IMapper _mapper;
        public DetailService(IDetailRepository DetailRepository, IMapper mapper) 
        {
            _DetailRepository = DetailRepository;
            _mapper = mapper;
        }

        public Task<bool> CreateDetailAsync(Details Detail)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDetailAsync(int id)
        {
            throw new NotImplementedException();
        }
        
        public Task<DetailsDto> GetDetailByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<DetailsDto>> GetDetailsAsync()
        {
            var Details = _DetailRepository.GetDetailsAsync(); //llamando el método desde la capa de repositorio
            
            return _mapper.Map<ICollection<DetailsDto>>(Details); //mapeando la lista de Detailas a DTOs


        }

        public Task<bool> DetailExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DetailExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDetailAsync(Details Detail)
        {
            throw new NotImplementedException();
        }
    }
}
