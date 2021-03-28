using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService:ICrudService<Category>
    {
        IDataResult<Category> GetById(int id);
    }
}
