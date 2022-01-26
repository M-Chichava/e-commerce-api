 using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> context) : base(context)
        {
            
        }
        public DbSet<Product> Products {get; set;}
    }
}
    