using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constanst;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<User> GetByUserId(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(c => c.Id == userId));
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _userDal.Add(user);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}
