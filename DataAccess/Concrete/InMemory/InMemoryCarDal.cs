using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;   //globaldeğişken

        public InMemoryCarDal()  // constructor
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=1997, DailyPrice=15000, Description="MaviOpel" },
                new Car{CarId=2, BrandId=1, ColorId=2, ModelYear=2021, DailyPrice=157000, Description="BeyazToyota" },
                new Car{CarId=3, BrandId=2, ColorId=2, ModelYear=2005, DailyPrice=97600, Description= "BeyazKia" },
                new Car{CarId=4, BrandId=2, ColorId=3, ModelYear=2017, DailyPrice=185300, Description="SiyahBmw" },
                new Car{CarId=5, BrandId=3, ColorId=3, ModelYear=2013, DailyPrice=172400, Description="SiyahMercedes" }


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

       
        public void Update(Car car)
        {
            //Gönderilen araba ıdsine sahip arabayı bul
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;


        }

       public List<Car> GetAllByBrandId(int BrandId)
        {
           return  _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
