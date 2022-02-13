using System.Collections.Generic;
using Core.Results;

namespace BLL.Interface
{
    public interface ICategoryService<T>
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int categoryId);
    }
}