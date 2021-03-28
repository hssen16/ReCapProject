using System;
using System.Collections.Generic;
using System.Text;
using Core.Business;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService:ICrudService<User>
    {
        IDataResult<User> GetById(int id);
        IDataResult<User> GetByMail(string mail);
        IDataResult<IList<OperationClaim>> GetClaims(User user);
        IResult ProfileUpdate(User user, string password);

    }
}
