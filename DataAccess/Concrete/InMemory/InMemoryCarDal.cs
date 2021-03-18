using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //class içinde metotların dışında =global değişken
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{BrandId = 1,ColorId = 1,DailyPrice = 590,Descriptions = "Bmw i8",Id = 1,ModelYear = "2018"},
                new Car{BrandId = 2,ColorId = 2,DailyPrice = 459,Descriptions = "Audi A3",Id = 2,ModelYear = "2017"},
                new Car{BrandId = 3,ColorId = 3,DailyPrice = 399,Descriptions = "Tesla Truck",Id = 3,ModelYear = "2019"},
                new Car{BrandId = 4,ColorId = 3,DailyPrice = 319,Descriptions = "Pegault 3008",Id = 4,ModelYear = "2016"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.FirstOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToBeUpdated = _car.SingleOrDefault(c => c.Id == car.Id);
            carToBeUpdated.BrandId = car.BrandId;
            carToBeUpdated.ColorId = car.ColorId;
            carToBeUpdated.DailyPrice = car.DailyPrice;
            carToBeUpdated.Descriptions = car.Descriptions;
            carToBeUpdated.Id = car.Id;
            carToBeUpdated.ModelYear = car.ModelYear;
        }
    }
}
