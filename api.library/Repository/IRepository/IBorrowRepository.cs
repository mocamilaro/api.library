using api.library.DAL.Models;

namespace api.library.Repository.IRepository
{
    public interface IBorrowRepository
    {
        Task<ICollection<Borrows>> GetBorrowsAsync(); //Me retorna una lista de Borrows
        Task<Borrows> GetBorrowByIdAsync(int id); //Me retorna una Borrow por su id
        Task<bool>BorrowExistsByIdAsync(int id); //Me retorna true o false si existe una Borrow por su id
        
        //Task<bool> BorrowExistsByNameAsync(string name); //Me retorna true o false si existe una Borrow por su nombre
        Task <bool>CreateBorrowAsync(Borrows borrow); //Me crea una nueva Borrow
        Task<bool> UpdateBorrowAsync(Borrows borrow); //Me actualiza una Borrow
        Task<bool> DeleteBorrowAsync(int id); //Me elimina una Borrow
    }
}
