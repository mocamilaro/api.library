using api.library.DAL;
using api.library.DAL.Models;
using api.library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;

namespace api.library.Repository
{
    public class BorrowRepository : IBorrowRepository
    {
        private readonly ApplicationDBContext _context;

        public BorrowRepository(ApplicationDBContext context)
        {
            _context = context;

        }

        public async Task<bool> CreateBorrowAsync(Borrows borrow)
        {
            borrow.CreatedDate = DateTime.UtcNow;
            _context.Borrow.AddAsync(borrow);
            return await SaveAsync();

        }

        public async Task<bool> DeleteBorrowAsync(int id)
        {
            var borrow = await GetBorrowByIdAsync(id);

            if (borrow == null)
            {
                return false;
            }

            _context.Borrow.Remove(borrow);
            return await SaveAsync();
        }

        public async Task<Borrows> GetBorrowByIdAsync(int id)
        {
            return await _context.Borrow.
                AsNoTracking().
                FirstOrDefaultAsync(p => p.Id == id); //lambda expression

        }

        public async Task<ICollection<Borrows>> GetBorrowsAsync()
        {
            return await _context.Borrow
                .AsNoTracking()
                .OrderBy(b => b.Borrow_date)
                .ToListAsync();
        }

        public async Task<bool> BorrowExistsByIdAsync(int id)
        {
            return await _context.Borrow.
                AsNoTracking().
                AnyAsync(p => p.Id == id); //lambda expression
        }

        public async Task<bool> UpdateBorrowAsync(Borrows borrow)
        {
            borrow.ModifiedDate = DateTime.UtcNow;
            _context.Borrow.Update(borrow);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false; ;
        }
    }
}
