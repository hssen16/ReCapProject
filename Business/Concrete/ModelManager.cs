using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    class ModelManager : IModelService
    {
        private IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public IDataResult<IList<Model>> GetAll(Expression<Func<Model, bool>> filter = null)
        {
            return new SuccessDataResult<IList<Model>>(_modelDal.GetAll(filter));
        }

        public IDataResult<Model> Get(Expression<Func<Model, bool>> filter)
        {
            return new SuccessDataResult<Model>(_modelDal.Get(filter));
        }

        public IDataResult<Model> GetById(int id)
        {
            return new SuccessDataResult<Model>(_modelDal.GetById(id));
        }

        public IResult Add(Model model)
        {
            _modelDal.Add(model);
            return new SuccessResult(Messages.ModelAdded);
        }

        public IResult Update(Model model)
        {
            _modelDal.Update(model);
            return new SuccessResult(Messages.ModelUpdated);
        }

        public IResult Delete(Model model)
        {
            _modelDal.Delete(model);
            return new SuccessResult(Messages.ModelDeleted);
        }
    }
}