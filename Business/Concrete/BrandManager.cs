using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using DataAccess.Abstract;
using Business.Constanst;
using DataAccess.Concrete.EntityFramework;
using System.Runtime.ConstrainedExecution;

namespace Business.Concrete
{
    
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<Brand> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandId == brandId));
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _brandDal.Add(brand);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}
