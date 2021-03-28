using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarImageService : ICrudService<CarImage>
    {
        IDataResult<CarImage> GetById(int id);
    }
}
