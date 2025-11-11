using api.library.DAL.Models;
using Lib_entidades.Modelos;

namespace api.library.Repository.IRepository
{
    public interface IDetailRepository
    {
        Task<ICollection<Details>> GetDetailsAsync(); //Me retorna una lista de Detail
        Task<Details> GetDetailByIdAsync(int id); //Me retorna una Detail por su id
        Task<bool>DetailExistsByIdAsync(int id); //Me retorna true o false si existe una Detail por su id
       
        // Task<bool> DetailExistsByNameAsync(string name); //Me retorna true o false si existe una Detail por su nombre
        Task <bool>CreateDetailAsync(Details detail); //Me crea una nueva Detail
        Task<bool> UpdateDetailAsync(Details detail); //Me actualiza una Detail
        Task<bool> DeleteDetailAsync(int id); //Me elimina una Detail
    }
}
