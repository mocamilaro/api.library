using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;

namespace api.library.Services.IServices
{
    public interface IDetailService
    {
        Task<ICollection<DetailsDto>> GetDetailsAsync(); //Me retorna una lista de Detail
        Task<DetailsDto> GetDetailByIdAsync(int id); //Me retorna una Detail por su id
        Task<bool>DetailExistsByIdAsync(int id); //Me retorna true o false si existe una Detail por su id
       
        // Task<bool> DetailExistsByNameAsync(string name); //Me retorna true o false si existe una Detail por su nombre
        Task <bool>CreateDetailAsync(Details detail); //Me crea una nueva Detail
        Task<bool> UpdateDetailAsync(Details detail); //Me actualiza una Detail
        Task<bool> DeleteDetailAsync(int id); //Me elimina una Detail
    }
}
