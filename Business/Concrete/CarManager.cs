using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public IResult  Add(Car car)
        {
            if (car.Description.Length <= 2 && car.DailyPrice < 0)
            {
                //magic strings
                return new ErrorResult(Messages.CarNameInvalıd);
            }
                 _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);

            
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>> ( _carDal.GetAll(), Messages.CarListed); //data,success,mesaage
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(c => c.CarId == id));
        }

        public IDataResult<List<Car>> GetAllByModelYear(int min, int max)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.ModelYear >= min && c.ModelYear <= max));
        }

        public IDataResult<List<Car>> GetByColorId(int id)
        {
            return new  SuccessDataResult<List<Car>> (_carDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Messages.CarUpdated); 

        }
    }
}
