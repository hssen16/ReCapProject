using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        public IDataResult<IList<Customer>> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> Get(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IResult Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
