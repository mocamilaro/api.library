using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;
using api.library.Repository.IRepository;
using api.library.Services.IServices;
using AutoMapper;

namespace api.library.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository UserRepository, IMapper mapper) 
        {
            _UserRepository = UserRepository;
            _mapper = mapper;
        }

        public Task<bool> CreateUserAsync(Users User)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }
        
        public Task<UsersDto> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<UsersDto>> GetUsersAsync()
        {
            var Users = _UserRepository.GetUsersAsync(); //llamando el método desde la capa de repositorio
            
            return _mapper.Map<ICollection<UsersDto>>(Users); //mapeando la lista de Useras a DTOs


        }

        public Task<bool> UserExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserAsync(Users User)
        {
            throw new NotImplementedException();
        }
    }
}
