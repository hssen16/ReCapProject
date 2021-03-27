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
    class BrandManager:IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<IList<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return new SuccessDataResult<IList<Brand>>(_brandDal.GetAll(filter));
        }

        public IDataResult<Brand> Get(Expression<Func<Brand, bool>> filter)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(filter));
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.GetById(id));
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }
    }
}