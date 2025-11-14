using api.library.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace api.library.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }


        //Sección para crear el dbset de cada entidad

        public DbSet<Persons>? Person { get; set; }
        public DbSet<Users>? User { get; set; }
        public DbSet<Books>? Book { get; set; }
        public DbSet<Copies>? Copy { get; set; }
        public DbSet<Borrows>? Borrow { get; set; }
        public DbSet<Details>? Detail { get; set; }


    }
}