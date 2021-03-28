using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Results;

namespace Core.Business
{
    public interface ICrudService<T>
    {
        IDataResult<IList<T>> GetAll(Expression<Func<T, bool>> filter = null);
        IDataResult<T> Get(Expression<Func<T, bool>> filter);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}
