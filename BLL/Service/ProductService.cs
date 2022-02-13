using System.Collections.Generic;
using BLL.Interface;
using Core.Results;

namespace BLL.Service.EfCoreService
{
    public class ProductService<T> : IProductService<T>
    {
        public IResult Add(T product)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(T product)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<T>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<T> GetById(int productId)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(T product)
        {
            throw new System.NotImplementedException();
        }
    }
}