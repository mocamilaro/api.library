using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;

namespace api.library.Services.IServices
{
    public interface ICopyService
    {
        Task<ICollection<CopiesDto>> GetCopiesAsync(); //Me retorna una lista de Copys
        Task<CopiesDto> GetCopyByIdAsync(int id); //Me retorna una Copy por su id
        Task<bool>CopyExistsByIdAsync(int id); //Me retorna true o false si existe una Copy por su id
       
        // Task<bool> CopyExistsByNameAsync(string name); //Me retorna true o false si existe una Copy por su nombre
        Task <bool>CreateCopyAsync(Copies copy); //Me crea una nueva Copy
        Task<bool> UpdateCopyAsync(Copies copy); //Me actualiza una Copy
        Task<bool> DeleteCopyAsync(int id); //Me elimina una Copy
    }
}
