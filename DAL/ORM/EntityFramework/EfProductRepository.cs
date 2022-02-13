using DAL.Interface;
using Entities.Model.EfCoreModel;

namespace DAL.ORM.EntityFramework
{
    public class EfProductRepository : EfBaseRepository<Product, EfCoreContext>, IProductDAL
    {
        
    }
}