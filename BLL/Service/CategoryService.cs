using System.Collections.Generic;
using BLL.Interface;
using Core.Results;
using Entities.Model.EfCoreModel;

namespace BLL.Service.EfCoreService
{
    public class CategoryService<T> : ICategoryService<T>
    {
        public IDataResult<List<T>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<T> GetById(int categoryId)
        {
            throw new System.NotImplementedException();
        }
    }
}