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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<Rental> GetByRentalId(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(c => c.Id == rentalId));
        }

        public IResult Add(Rental rental)
        {
            var existingRental = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate >= rental.ReturnDate);

            if (existingRental != null)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _rentalDal.Add(rental);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}
