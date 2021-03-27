using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        Car GetById(int id);
       
        IList<Car> GetByBrandId(int brandId);
        IList<Car> GetByModelId(int modelId);
        IList<Car> GetByColorId(int colorId);
    }
}
