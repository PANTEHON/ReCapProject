using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args) 
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { CarId = 1, CarName = "Audi", BrandId = 1, ColorId = 1, ModelYear = 2022, DailyPrice = 80, Description = "Konforlu yolculuk" });
            carManager.Add(new Car {CarId = 2, CarName = "BMW", BrandId = 2,ColorId = 2, ModelYear = 2023, DailyPrice =110, Description ="Hız ve güvenilir yolculuk"});
            carManager.Add(new Car {CarId = 3, CarName ="Mercedes-Benz", BrandId = 3, ColorId = 3, ModelYear = 2020, DailyPrice = 60, Description = "Konfor ve hız için bir numara" });
            carManager.Add(new Car {CarId = 4, CarName = "Range Rover", BrandId = 4, ColorId = 4, ModelYear = 2019, DailyPrice = 70, Description = "Güvenilir ve kondor için birebir"});
            



            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + " - " + car.ModelYear + " - $" + car.DailyPrice + " - " + car.Description);
            }

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.BrandId + " " + car.Description);
            }

            foreach (var car in carManager.GetCarsByColorId(5))
            {
                Console.WriteLine(car.ColorId + " " + car.Description);
            }
        }
    }


}