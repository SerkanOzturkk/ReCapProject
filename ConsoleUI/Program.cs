// See https://aka.ms/new-console-template for more information

using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


CarManager carManager = new CarManager(new EfCarDal());

/*
carManager.Add(new Car()
{
    BrandId = 1,
    CarName = "Aston Martin",
    ColorId = 2,
    DailyPrice = 500,
    Description = "fancy car",
    ModelYear = "2020"
});*/

/*carManager.Update(new Car()
{
    CarId = 6,
    BrandId = 1,
    CarName = "test",
    ColorId = 2,
    DailyPrice = 500,
    Description = "fancy car",
    ModelYear = "2024"
});*/

/*carManager.Delete(new Car()
{
    CarId = 6,
    BrandId = 1,
    CarName = "test",
    ColorId = 2,
    DailyPrice = 500,
    Description = "fancy car"
    
});*/




foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.CarId+" ----- " + car.CarName + " ----- " + car.Description + " ----- " + car.ModelYear);
}

