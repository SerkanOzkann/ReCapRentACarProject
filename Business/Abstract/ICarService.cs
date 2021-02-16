﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetAllByBrandId(int id);

        List<Car> GetByColorId(int id);

        List<Car> GetAllByModelYear(int min, int max);

        List<Car> GetByDailyPrice(decimal min, decimal max);

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}