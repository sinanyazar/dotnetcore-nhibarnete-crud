using System.Collections.Generic;
using BLL.Interface;
using Core.Results;
using DAL.Interface;
//using Entities.Model.EfCoreModel;
using Entities.Model.NHibarnateModel;

namespace BLL.Service.EfCoreService
{
    public class CategoryService : ICategoryService<Category>
    {
        ICategoryDAL _categoryDal;
        public CategoryService(ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(categoryId));
        }
    }
}