using api.library.DAL;
using api.library.DAL.Models;
using api.library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;

namespace api.library.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDBContext _context;

        public BookRepository(ApplicationDBContext context)
        {
            _context = context;

        }

        public async Task<bool> CreateBookAsync(Books book)
        {
            book.CreatedDate = DateTime.UtcNow;
            _context.Book.AddAsync(book);
            return await SaveAsync();

        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var book = await GetBookByIdAsync(id);

            if (book == null)
            {
                return false;
            }

            _context.Book.Remove(book);
            return await SaveAsync();
        }

        public async Task<Books> GetBookByIdAsync(int id)
        {
            return await _context.Book.
                AsNoTracking().
                FirstOrDefaultAsync(p => p.Id == id); //lambda expression

        }

        public async Task<ICollection<Books>> GetBooksAsync()
        {
            return await _context.Book
                .AsNoTracking()
                .OrderBy(p => p.Book_Name)
                .ToListAsync();
        }

        public async Task<bool> BookExistsByIdAsync(int id)
        {
            return await _context.Book.
                AsNoTracking().
                AnyAsync(p => p.Id == id); //lambda expression
        }

        public async Task<bool> BookExistsByNameAsync(string name)
        {
            return await _context.Book.
                AsNoTracking().
                AnyAsync(p => p.Book_Name == name); //lambda expression
        }

        public async Task<bool> UpdateBookAsync(Books book)
        {
            book.ModifiedDate = DateTime.UtcNow;
            _context.Book.Update(book);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false; ;
        }
    }
}
