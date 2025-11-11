using api.library.DAL;
using api.library.DAL.Models;
using api.library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;

namespace api.library.Repository
{
    public class DetailRepository : IDetailRepository
    {
        private readonly ApplicationDBContext _context;

        public DetailRepository(ApplicationDBContext context)
        {
            _context = context;

        }

        public async Task<bool> CreateDetailAsync(Details detail)
        {
            detail.CreatedDate = DateTime.UtcNow;
            _context.Detail.AddAsync(detail);
            return await SaveAsync();

        }

        public async Task<bool> DeleteDetailAsync(int id)
        {
            var detail = await GetDetailByIdAsync(id);

            if (detail == null)
            {
                return false;
            }

            _context.Detail.Remove(detail);
            return await SaveAsync();
        }

        public async Task<Details> GetDetailByIdAsync(int id)
        {
            return await _context.Detail.
                AsNoTracking().
                FirstOrDefaultAsync(p => p.Id == id); //lambda expression

        }

        public async Task<ICollection<Details>> GetDetailsAsync()
        {
            return await _context.Detail
                .AsNoTracking()
                .OrderBy(p => p.Return_date)
                .ToListAsync();
        }

        public async Task<bool> DetailExistsByIdAsync(int id)
        {
            return await _context.Detail.
                AsNoTracking().
                AnyAsync(p => p.Id_detail == id); //lambda expression
        }

        public async Task<bool> UpdateDetailAsync(Details detail)
        {
            detail.ModifiedDate = DateTime.UtcNow;
            _context.Detail.Update(detail);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false; ;
        }
    }
}
