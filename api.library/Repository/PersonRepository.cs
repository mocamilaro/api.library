using api.library.DAL;
using api.library.DAL.Models;
using api.library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;

namespace api.library.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDBContext _context;

        public PersonRepository(ApplicationDBContext context)
        {
            _context = context;

        }

        public async Task<bool> CreatePersonAsync(Persons person)
        {
            person.CreatedDate = DateTime.UtcNow;
            _context.Person.AddAsync(person);
            return await SaveAsync();

        }

        public async Task<bool> DeletePersonAsync(int id)
        {
            var person = await GetPersonByIdAsync(id);

            if (person == null)
            {
                return false;
            }

            _context.Person.Remove(person);
            return await SaveAsync();
        }

        public async Task<Persons> GetPersonByIdAsync(int id)
        {
            return await _context.Person.
                AsNoTracking().
                FirstOrDefaultAsync(p => p.Id == id); //lambda expression

        }

        public async Task<ICollection<Persons>> GetPersonsAsync()
        {
            return await _context.Person
                .AsNoTracking()
                .OrderBy(p => p.Name)
                .ToListAsync();
        }

        public async Task<bool> PersonExistsByDocAsync(string doc_id)
        {
            return await _context.Person.
                AsNoTracking().
                AnyAsync(p => p.Doc_id == doc_id); //lambda expression
        }

        public async Task<bool> PersonExistsByNameAsync(string name)
        {
            return await _context.Person.
                AsNoTracking().
                AnyAsync(p => p.Name == name); //lambda expression
        }

        public async Task<bool> UpdatePersonAsync(Persons person)
        {
            person.ModifiedDate = DateTime.UtcNow;
            _context.Person.Update(person);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false; ;
        }
    }
}
