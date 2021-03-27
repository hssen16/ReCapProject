using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IColorService
   {
       IDataResult<IList<Color>> GetAll(Expression<Func<Color, bool>> filter = null);
       IDataResult<Color> Get(Expression<Func<Color, bool>> filter);
       IDataResult<Color> GetById(int id);
       IResult Add(Color color);
       IResult Update(Color color);
       IResult Delete(Color color);
   }
}
