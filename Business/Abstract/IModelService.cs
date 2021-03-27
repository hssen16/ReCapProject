﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IModelService
    {
        IDataResult<IList<Model>> GetAll(Expression<Func<Model, bool>> filter = null);
        IDataResult<Model> Get(Expression<Func<Model, bool>> filter);
        IDataResult<Model> GetById(int id);
        IResult Add(Model model);
        IResult Update(Model model);
        IResult Delete(Model model);

    }
}
