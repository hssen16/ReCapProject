using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [CacheAspect]
        public IDataResult<IList<User>> GetAll(Expression<Func<User, bool>> filter = null)
        {
            var result = _userDal.GetAll(filter);
            return result.Count == 0
                ? (IDataResult<IList<User>>)new ErrorDataResult<IList<User>>(result)
                : new SuccessDataResult<IList<User>>(result);
        }

        public IDataResult<User> Get(Expression<Func<User, bool>> filter)
        {
            var result = _userDal.Get(filter);
            return result != null
                ? (IDataResult<User>)new SuccessDataResult<User>(result)
                : new ErrorDataResult<User>(result);
        }

        [CacheRemoveAspect("IUserService.Get")]
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        [CacheRemoveAspect("IUserService.Get")]
        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        [CacheRemoveAspect("IUserService.Get")]
        [SecuredOperation("User.Delete")]
        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<User> GetById(int id)
        {
            var result = _userDal.GetById(id);
            return result == null ? (IDataResult<User>)new ErrorDataResult<User>(result) : new SuccessDataResult<User>(result);
        }

        public IDataResult<User> GetByMail(string mail)
        {
            var result = _userDal.GetByMail(mail);
            return result == null
                ? (IDataResult<User>)new ErrorDataResult<User>(result)
                : new SuccessDataResult<User>(result);
        }

        public IDataResult<IList<OperationClaim>> GetClaims(User user)
        {
            var result = _userDal.GetClaims(user);
            return result.Count == 0
                ? (IDataResult<IList<OperationClaim>>)new ErrorDataResult<IList<OperationClaim>>(result)
                : new SuccessDataResult<IList<OperationClaim>>(result);
        }

        public IResult ProfileUpdate(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var updatedUser = new User
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = user.Status
            };
            _userDal.Update(updatedUser);
            return new SuccessDataResult<User>(Messages.UserUpdated);
        }
    }
}
