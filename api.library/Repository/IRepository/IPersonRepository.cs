using api.library.DAL.Models;

namespace api.library.Repository.IRepository
{
    public interface IPersonRepository
    {
        Task<ICollection<Persons>> GetPersonsAsync(); //Me retorna una lista de personas
        Task<Persons> GetPersonByIdAsync(int id); //Me retorna una persona por su id
        Task<bool>PersonExistsByIdAsync(int id); //Me retorna true o false si existe una persona por su id
        Task<bool> PersonExistsByNameAsync(string name); //Me retorna true o false si existe una persona por su nombre
        Task <bool>CreatePersonAsync(Persons person); //Me crea una nueva persona
        Task<bool> UpdatePersonAsync(Persons person); //Me actualiza una persona
        Task<bool> DeletePersonAsync(int id); //Me elimina una persona
    }
}
