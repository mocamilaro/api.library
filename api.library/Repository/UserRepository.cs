using api.library.DAL;
using api.library.DAL.Models;
using api.library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;

namespace api.library.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;

        public UserRepository(ApplicationDBContext context)
        {
            _context = context;

        }

        public async Task<bool> CreateUserAsync(Users user)
        {
            user.CreatedDate = DateTime.UtcNow;
            _context.User.AddAsync(user);
            return await SaveAsync();

        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await GetUserByIdAsync(id);

            if (user == null)
            {
                return false;
            }

            _context.User.Remove(user);
            return await SaveAsync();
        }

        public async Task<Users> GetUserByIdAsync(int id)
        {
            return await _context.User.
                AsNoTracking().
                FirstOrDefaultAsync(p => p.Id == id); //lambda expression

        }

        public async Task<ICollection<Users>> GetUsersAsync()
        {
            return await _context.User
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<bool> UserExistsByIdAsync(int id)
        {
            return await _context.User.
                AsNoTracking().
                AnyAsync(p => p.Id == id); //lambda expression
        }


        public async Task<bool> UpdateUserAsync(Users user)
        {
            user.ModifiedDate = DateTime.UtcNow;
            _context.User.Update(user);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false; ;
        }
    }
}
