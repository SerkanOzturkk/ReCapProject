// See https://aka.ms/new-console-template for more information

using Business.Abstract;
using Business.Concrete;
using Business.Test;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            TestCar testCar = new TestCar();
            //testCar.GetAll();
            //testCar.GetByID(1);
            //testCar.Add(new Car{BrandId = 1,CarName = "test1",DailyPrice = 250,ModelYear = "2023",ColorId = 1,Description = "test"});
            //testCar.Update(new Car { CarId = 9, BrandId = 1, CarName = "asd", DailyPrice = 250, ModelYear = "2024",Description = "test",ColorId = 1});
            //testCar.Delete(new Car { CarId = 9});
            //testCar.GetCarDetails();
            //testCar.GetCarsByBrandId(3);



        }

        

    }
}



