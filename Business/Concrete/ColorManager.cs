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
    class ColorManager:IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<IList<Color>> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return new SuccessDataResult<IList<Color>>(_colorDal.GetAll(filter));
        }

        public IDataResult<Color> Get(Expression<Func<Color, bool>> filter)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(filter));
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.GetById(id));
        }

        public IResult Add(Color color)
        {
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Update(Color color)
        {
            return new SuccessResult(Messages.ColorUpdated);
        }

        public IResult Delete(Color color)
        {
            return new SuccessResult(Messages.ColorDeleted);
        }
    }
}