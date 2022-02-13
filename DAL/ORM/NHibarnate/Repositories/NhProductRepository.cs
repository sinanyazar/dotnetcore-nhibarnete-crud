using Entities.Model.NHibarnateModel;
using NHibernate;

namespace DAL.ORM.NHibarnate.Repositories
{
    public class NhProductRepository : NhBaseRepository<Product>
    {
        public NhProductRepository(ISession session) : base(session)
        {
        }
    }
}