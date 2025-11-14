using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;

namespace api.library.Services.IServices
{
    public interface IBookService
    {
        Task<ICollection<BooksDto>> GetBooksAsync(); //Me retorna una lista de Book
        Task<BooksDto> GetBookByIdAsync(int id); //Me retorna una Book por su id
        Task<bool>BookExistsByIdAsync(int id); //Me retorna true o false si existe una Book por su id
        //Task<bool> BookExistsByNameAsync(string name); //Me retorna true o false si existe una Book por su nombre
        Task <bool>CreateBookAsync(Books book); //Me crea una nueva Book
        Task<bool> UpdateBookAsync(Books book); //Me actualiza una Book
        Task<bool> DeleteBookAsync(int id); //Me elimina una Book
    }
}
