using BlazorCrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }

        public DbSet<Book> Books { get; set; }
    }
}
