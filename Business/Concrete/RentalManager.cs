using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var rentalsReturnDate = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            var hasCustomersRentedCar = _rentalDal.GetAll(c => c.CustomerId == rental.CustomerId);
            bool carVarMi = false;
            bool customerVarMi = false;

            if (rentalsReturnDate.Count > 0 || hasCustomersRentedCar.Count > 0)
            {
                foreach (var rentalreturnDate in rentalsReturnDate)
                {
                    if (rentalreturnDate.ReturnDate == default)
                    {
                        carVarMi = true;
                    }
                }

                foreach (var hasCustomerRentedCar in hasCustomersRentedCar)
                {
                    if (hasCustomerRentedCar.ReturnDate == default)
                    {
                        customerVarMi = true;
                    }
                }

                if (carVarMi && customerVarMi == false)
                {
                    return new ErrorResult( " for car");
                }

                else if (customerVarMi && carVarMi == false)
                {
                    return new ErrorResult( " for customer");
                }

                else if (customerVarMi && carVarMi)
                {
                    return new ErrorResult(  " for customer and car");
                }
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }
    

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetAllById(int RentalId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentalId == RentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetAllRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.RentalListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
