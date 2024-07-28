using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1,BrandId = 1,ColorId = 1,ModelYear = "2015",DailyPrice = 20.000,Description = "Fiat"},
                new Car{CarId = 2,BrandId = 1,ColorId = 1,ModelYear = "2018",DailyPrice = 30.000,Description = "Opel"},
                new Car{CarId = 3,BrandId = 2,ColorId = 2,ModelYear = "2023",DailyPrice = 55.000,Description = "Mercedes"},
                new Car{CarId = 4,BrandId = 2,ColorId = 2,ModelYear = "2022",DailyPrice = 45.000,Description = "Bmw"},
                new Car{CarId = 5,BrandId = 3,ColorId = 2,ModelYear = "2021",DailyPrice = 40.000,Description = "Renault"}
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetById(int CarId)
        {
            var wantedCar = _cars.Where(c => c.CarId == CarId);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
