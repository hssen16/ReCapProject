using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IBrandService
   {
       IDataResult<IList<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null);
       IDataResult<Brand> Get(Expression<Func<Brand, bool>> filter);
       IDataResult<Brand> GetById(int id);
       IResult Add(Brand brand);
       IResult Update(Brand brand);
       IResult Delete(Brand brand);

   }
}
