using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
       IDataResult<List<Car>>  GetAll();

        IDataResult<List<Car>> GetAllByBrandId(int id);

        IDataResult<List<Car>> GetByColorId(int id);

        IDataResult<List<Car>> GetAllByModelYear(int min, int max);

        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);

        IResult  Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
