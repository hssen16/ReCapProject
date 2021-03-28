using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Entities;
using Core.Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        IList<OperationClaim> GetClaims(User user);
        User GetById(int id);
        User GetByMail(string mail);
    }
}
