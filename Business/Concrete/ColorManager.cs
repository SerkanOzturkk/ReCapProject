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

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<Color> GetByColorId(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == colorId));
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _colorDal.Add(color);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}
