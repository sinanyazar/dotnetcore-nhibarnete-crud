using DAL.Interface;
using Entities.Model.NHibarnateModel;
using NHibernate;

namespace DAL.ORM.NHibarnate.Repositories
{
    public class NhCategoryRepository : NhBaseRepository<Category>, ICategoryDAL
    {
        public NhCategoryRepository(ISession session) : base(session)
        {
        }
    }
}