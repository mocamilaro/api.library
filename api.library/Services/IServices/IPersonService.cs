using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;

namespace api.library.Services.IServices
{
    public interface IPersonService
    {
        Task<ICollection<PersonsDto>> GetPersonsAsync(); //Me retorna una lista de personas
        Task<PersonsDto> GetPersonByIdAsync(int id); //Me retorna una persona por su id
        Task<bool> PersonExistsByDocAsync(string doc_id); //Me retorna true o false si existe una persona por su id
        Task<bool> PersonExistsByNameAsync(string name); //Me retorna true o false si existe una persona por su nombre
        Task<PersonsDto> CreatePersonAsync(PersonsCreateDto person); //Me crea una nueva persona
        Task<PersonsDto> UpdatePersonAsync(PersonsDto person); //Me actualiza una persona
        Task<bool> DeletePersonAsync(int id); //Me elimina una persona
    }
}
