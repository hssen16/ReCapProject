using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<IList<Car>> GetAll(Expression<Func<Car, bool>> filter = null);
        IDataResult<IList<Car>> GetByBrandId(int brandId);
        IDataResult<IList<Car>> GetByModelId(int modelId);
        IDataResult<IList<Car>> GetByColorId(int colorId);
        IDataResult<Car> Get(Expression<Func<Car,bool>> filter);
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
