using System.Collections.Generic;
using Core.Results;

namespace BLL.Interface
{
    public interface IProductService<T>
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int productId);
        IResult Add(T product);
        IResult Update(T product);
        IResult Delete(T product);
    }
}