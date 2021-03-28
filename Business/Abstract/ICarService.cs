using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService:ICrudService<Car>
    {
     
        IDataResult<IList<Car>> GetByBrandId(int brandId);
        IDataResult<IList<Car>> GetByModelId(int modelId);
        IDataResult<IList<Car>> GetByColorId(int colorId);
    
        IDataResult<Car> GetById(int id);
       
    }
}
