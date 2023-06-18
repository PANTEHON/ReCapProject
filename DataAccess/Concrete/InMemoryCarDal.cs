using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=550000, ModelYear=2014, Description="BMW E60"},
                new Car{CarId=2, BrandId=1, ColorId=2, DailyPrice=650000, ModelYear=2016, Description="BMW M3 Coupe"},
                new Car{CarId=3, BrandId=2, ColorId=3, DailyPrice=800000, ModelYear=2018, Description="Audi A4"},
                new Car{CarId=4, BrandId=3, ColorId=1, DailyPrice=950000, ModelYear=2020, Description="Range Rover Evoque"},
                new Car{CarId=5, BrandId=4, ColorId=3, DailyPrice=1500000, ModelYear=2021, Description="Mercedes-Benz C 63"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars; 
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
