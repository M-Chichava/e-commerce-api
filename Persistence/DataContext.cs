using System.Reflection;
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
        public DbSet<ProductBrand> ProductBrands {get; set;}
        public DbSet<ProductType> ProductTypes {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
    