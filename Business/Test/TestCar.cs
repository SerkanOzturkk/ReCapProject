using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Test
{
    public  class TestCar : ITest
    {
        CarManager carManager = new CarManager(new EfCarDal(),new BrandManager(new EfBrandDal()));
        public void GetAll()
        {
            var result = carManager.GetAll();



            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " -  " + car.CarName + " -  " + car.BrandId
                                      + " -  " + car.DailyPrice + " -  " + car.ModelYear);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void GetByID(int Id)
        {
            var result = carManager.GetByCarId(Id);

            if (result.Success == true)
            {
                var car = result.Data;
                Console.WriteLine(car.CarId + " -  " + car.CarName + " -  " + car.BrandId
                                  + " -  " + car.DailyPrice + " -  " + car.ModelYear);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }


        public void Add(Car car)
        {
            var result = carManager.Add(car);

            if (result.Success == true)
            {
                GetAll();
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void Update(Car car)
        {
            var result = carManager.Update(car);

            if (result.Success == true)
            {
                GetAll();
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void Delete(Car car)
        {
            var result = carManager.Delete(car);

            if (result.Success == true)
            {
                GetAll();
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void GetCarDetails()
        {
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " -  " + car.CarName + " -  " + car.BrandName
                                      + " -  " + car.ColorName + " - " + car.ModelYear);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }


        public void GetCarsByBrandId(int brandId)
        {
            var result = carManager.GetByCarId(brandId);

            if (result.Success == true)
            {
                var car = result.Data;
                Console.WriteLine(car.CarId + " -  " + car.CarName + " -  " + car.BrandId
                                  + " -  " + car.DailyPrice + " -  " + car.ModelYear);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void GetCarsByColorId(int colorId)
        {
            var result = carManager.GetByCarId(colorId);

            if (result.Success == true)
            {
                var car = result.Data;
                Console.WriteLine(car.CarId + " -  " + car.CarName + " -  " + car.BrandId
                                  + " -  " + car.DailyPrice + " -  " + car.ModelYear);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        
        
        
    }
}
