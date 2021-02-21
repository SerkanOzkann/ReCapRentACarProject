using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
       IUserDal  _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.UserFirstName.Length <=2)
            {
                return new ErrorResult(Messages.UserNameInvalıd);
            }

            _userDal.Add(user);

            return new SuccessResult(Messages.UserAdded);
            
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);

            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
        }

        public IDataResult<List<User>> GetAllById(int UserId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.UserId == UserId ));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);

            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
