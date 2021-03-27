using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        Car GetById(int id);
        Car GetByName(string name);
        Car GetByBrandId(int brandId);
        Car GetByModelId(int modelId);
        Car GetBy
    }
}
