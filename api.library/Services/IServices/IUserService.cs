using api.library.DAL.Models;
using api.library.DAL.Models.Dtos;

namespace api.library.Services.IServices
{
    public interface IUserService
    {
        Task<ICollection<UsersDto>> GetUsersAsync(); //Me retorna una lista de usuarios
        Task<UsersDto> GetUserByIdAsync(int id); //Me retorna una usuario por su id
        Task<bool>UserExistsByIdAsync(int id); //Me retorna true o false si existe una usuario por su id
        //Task<bool> UserExistsByNameAsync(string name); //Me retorna true o false si existe una usuario por su nombre
        Task <bool>CreateUserAsync(Users user); //Me crea una nueva usuario
        Task<bool> UpdateUserAsync(Users user); //Me actualiza una usuario
        Task<bool> DeleteUserAsync(int id); //Me elimina una usuario
    }
}
