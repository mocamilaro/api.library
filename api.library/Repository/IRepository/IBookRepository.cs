using api.library.DAL.Models;

namespace api.library.Repository.IRepository
{
    public interface IBookRepository
    {
        Task<ICollection<Books>> GetBooksAsync(); //Me retorna una lista de Book
        Task<Books> GetBookByIdAsync(int id); //Me retorna una Book por su id
        Task<bool>BookExistsByIdAsync(int id); //Me retorna true o false si existe una Book por su id
        Task<bool> BookExistsByNameAsync(string name); //Me retorna true o false si existe una Book por su nombre
        Task <bool>CreateBookAsync(Books book); //Me crea una nueva Book
        Task<bool> UpdateBookAsync(Books book); //Me actualiza una Book
        Task<bool> DeleteBookAsync(int id); //Me elimina una Book
    }
}
