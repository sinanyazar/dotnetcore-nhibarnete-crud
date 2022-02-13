using Entities.Model.EfCoreModel;
using Microsoft.EntityFrameworkCore;

namespace DAL.ORM.EntityFramework
{
    public class EfCoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LC4GVGJ\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}