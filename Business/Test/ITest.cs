using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entites;
using Entities.Concrete;

namespace Business.Test
{
    public interface ITest
    {
        void GetAll();
        void GetByID(int Id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        void GetCarDetails();
        void GetCarsByBrandId(int brandId);
        void GetCarsByColorId(int colorId);

    }
}
