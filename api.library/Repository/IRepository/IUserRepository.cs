using api.library.DAL.Models;

namespace api.library.Repository.IRepository
{
    public interface IUserRepository
    {
        Task<ICollection<Users>> GetUsersAsync(); //Me retorna una lista de usuarios
        Task<Users> GetUserByIdAsync(int id); //Me retorna una usuario por su id
        Task<bool>UserExistsByIdAsync(int id); //Me retorna true o false si existe una usuario por su id
        //Task<bool> UserExistsByNameAsync(string name); //Me retorna true o false si existe una usuario por su nombre
        Task <bool>CreateUserAsync(Users user); //Me crea una nueva usuario
        Task<bool> UpdateUserAsync(Users user); //Me actualiza una usuario
        Task<bool> DeleteUserAsync(int id); //Me elimina una usuario
    }
}
