using Entities.Model.EfCoreModel;
using Microsoft.EntityFrameworkCore;

namespace DAL.ORM.EntityFramework
{
    public class EfCoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}