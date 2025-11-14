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

        public async Task<PersonsDto> CreatePersonAsync(PersonsCreateDto createpersonDto)
        {
            //Validar si la persona ya existe
            var personExists = await _personRepository.PersonExistsByDocAsync(createpersonDto.Doc_id);
            if (personExists)
            {
                throw new InvalidOperationException($"Ya existe una persona con el número de documento '{createpersonDto.Doc_id}'"); //La persona ya existe
            }

            var person = _mapper.Map<Persons>(createpersonDto); //Mapear el DTO a la entidad Persons

            //Llamar al repositorio para crear la persona
            var personCreated = await _personRepository.CreatePersonAsync(person);

            if (!personCreated)
            {
                throw new Exception("Error al crear la persona"); //Error al crear la persona
            }

            //Mapear la entidad Persons a DTO y devolver el resultado
            return _mapper.Map<PersonsDto>(person);
        }

        public Task<bool> DeletePersonAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PersonsDto> GetPersonByIdAsync(int id)
        {
            var personDto = await _personRepository.GetPersonByIdAsync(id); //llamando el método desde la capa de repositorio

            return _mapper.Map<PersonsDto>(personDto); //mapeando la lista de personas a DTOs
        }

        public async Task<ICollection<PersonsDto>> GetPersonsAsync()
        {
            var persons = await _personRepository.GetPersonsAsync(); //llamando el método desde la capa de repositorio
            
            return _mapper.Map<ICollection<PersonsDto>>(persons); //mapeando la lista de personas a DTOs

        }

        public async Task<bool> PersonExistsByDocAsync(string doc_id)
        {
            return await _personRepository.PersonExistsByDocAsync(doc_id);
        }

        public async Task<bool> PersonExistsByNameAsync(string name)
        {
            return await _personRepository.PersonExistsByNameAsync(name);
        }

        public Task<PersonsDto> UpdatePersonAsync(PersonsDto person)
        {
            throw new NotImplementedException();
        }
    }
}
