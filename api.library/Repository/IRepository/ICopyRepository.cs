using api.library.DAL.Models;

namespace api.library.Repository.IRepository
{
    public interface ICopyRepository
    {
        Task<ICollection<Copies>> GetCopiesAsync(); //Me retorna una lista de Copys
        Task<Copies> GetCopyByIdAsync(int id); //Me retorna una Copy por su id
        Task<bool>CopyExistsByIdAsync(int id); //Me retorna true o false si existe una Copy por su id
       
        // Task<bool> CopyExistsByNameAsync(string name); //Me retorna true o false si existe una Copy por su nombre
        Task <bool>CreateCopyAsync(Copies copy); //Me crea una nueva Copy
        Task<bool> UpdateCopyAsync(Copies copy); //Me actualiza una Copy
        Task<bool> DeleteCopyAsync(int id); //Me elimina una Copy
    }
}
