using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        Car GetById(int id);
        IList<Car> GetByBrandId(int brandId);
        IList<Car> GetByModelId(int modelId);
        IList<Car> GetByColorId(int colorId);
        IList<CarDetail> GetCarDetails(Expression<Func<Car, bool>> filter = null);
    }
}
