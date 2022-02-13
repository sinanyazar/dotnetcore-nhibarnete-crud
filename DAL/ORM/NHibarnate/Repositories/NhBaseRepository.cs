using System.Collections.Generic;
using System.Linq;
using DAL.Interface;
using NHibernate;

namespace DAL.ORM.NHibarnate.Repositories
{
    public abstract class NhBaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly ISession _session;

        public NhBaseRepository(ISession session)
        {
            _session = session;
        }
        
        public void Add(TEntity entity)
        {
            _session.Save(entity);
            _session.Flush();
        }

        public void Delete(TEntity entity)
        {
            _session.Delete(entity);
            _session.Flush();
        }

        public TEntity Get(int id)
        {
            _session.CacheMode = CacheMode.Normal;
            return _session.Get<TEntity>(id);
        }

        public List<TEntity> GetAll()
        {
            return _session.Query<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            _session.Update(entity);
            _session.Flush();
        }
    }
}