using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;

namespace api.library.Services.IServices
{
    public interface IBorrowService
    {
        Task<ICollection<BorrowsDto>> GetBorrowsAsync(); //Me retorna una lista de Borrows
        Task<BorrowsDto> GetBorrowByIdAsync(int id); //Me retorna una Borrow por su id
        Task<bool>BorrowExistsByIdAsync(int id); //Me retorna true o false si existe una Borrow por su id
        
        //Task<bool> BorrowExistsByNameAsync(string name); //Me retorna true o false si existe una Borrow por su nombre
        Task <bool>CreateBorrowAsync(Borrows borrow); //Me crea una nueva Borrow
        Task<bool> UpdateBorrowAsync(Borrows borrow); //Me actualiza una Borrow
        Task<bool> DeleteBorrowAsync(int id); //Me elimina una Borrow
    }
}
