using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IRepository<T> where T : class,new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}