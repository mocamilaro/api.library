using api.library.DAL;
using api.library.DAL.Models;
using api.library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;

namespace api.library.Repository
{
    public class CopyRepository : ICopyRepository
    {
        private readonly ApplicationDBContext _context;

        public CopyRepository(ApplicationDBContext context)
        {
            _context = context;

        }

        public async Task<bool> CreateCopyAsync(Copies copy)
        {
            copy.CreatedDate = DateTime.UtcNow;
            _context.Copy.AddAsync(copy);
            return await SaveAsync();

        }

        public async Task<bool> DeleteCopyAsync(int id)
        {
            var copy = await GetCopyByIdAsync(id);

            if (copy == null)
            {
                return false;
            }

            _context.Copy.Remove(copy);
            return await SaveAsync();
        }

        public async Task<Copies> GetCopyByIdAsync(int id)
        {
            return await _context.Copy.
                AsNoTracking().
                FirstOrDefaultAsync(p => p.Id == id); //lambda expression

        }

        public async Task<ICollection<Copies>> GetCopiesAsync()
        {
            return await _context.Copy
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<bool> CopyExistsByIdAsync(int id)
        {
            return await _context.Copy.
                AsNoTracking().
                AnyAsync(p => p.Id == id); //lambda expression
        }

        public async Task<bool> UpdateCopyAsync(Copies copy)
        {
            copy.ModifiedDate = DateTime.UtcNow;
            _context.Copy.Update(copy);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false; ;
        }
    }
}
