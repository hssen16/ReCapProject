using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,RentACarContext>,IUserDal
    {
        public IList<OperationClaim> GetClaims(User user)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim {Id = operationClaim.Id, Name = operationClaim.Name};
                return result.ToList();
            }
        }

        public User GetById(int id)
        {
            using (RentACarContext context=new RentACarContext())
            {
                return context.Users.SingleOrDefault(u => u.Id == id);
            }
        }

        public User GetByMail(string mail)
        {
            using (RentACarContext context=new RentACarContext())
            {
                return context.Users.SingleOrDefault(u => u.Email == mail);
            }
        }
    }
}
