using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;
using api.library.Repository.IRepository;
using api.library.Services.IServices;
using AutoMapper;

namespace api.library.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public PersonService(IPersonRepository personRepository, IMapper mapper) 
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public Task<bool> CreatePersonAsync(Persons person)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePersonAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PersonsDto> GetPersonByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<PersonsDto>> GetPersonsAsync()
        {
            var persons = await _personRepository.GetPersonsAsync(); //llamando el método desde la capa de repositorio
            
            return _mapper.Map<ICollection<PersonsDto>>(persons); //mapeando la lista de personas a DTOs


        }

        public Task<bool> PersonExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PersonExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePersonAsync(Persons person)
        {
            throw new NotImplementedException();
        }
    }
}
