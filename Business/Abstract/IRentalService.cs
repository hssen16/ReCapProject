﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService:ICrudService<Rental>
    {
        IDataResult<Rental> GetById(int id);
    }
}
