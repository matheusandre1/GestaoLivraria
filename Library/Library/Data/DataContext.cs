using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {


        }

        public DbSet<Book> Books { get; set; }
    }
}
