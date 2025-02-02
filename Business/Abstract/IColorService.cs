﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IColorService:ICrudService<Color>
   {
   
       IDataResult<Color> GetById(int id);
      
   }
}
