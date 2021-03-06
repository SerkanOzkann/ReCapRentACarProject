﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDetailDto>> GetAllRentalDetails();
        IDataResult<List<Rental>> GetAllById(int RentalId);

        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        


    }
}
