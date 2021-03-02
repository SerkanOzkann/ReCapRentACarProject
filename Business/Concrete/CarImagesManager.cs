using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImagesManager : ICarImagesService
    {
        ICarImagesDal _carImageDal;

        public CarImagesManager(ICarImagesDal carImagesDal)
        {
            _carImageDal = carImagesDal;
        }

        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult Add(IFormFile file, CarImages carImages)
        {
            IResult result = BusinessRules.Run(CheckImageLimitExceeded(carImages.CarId));
            if (result!=null)
            {
                return result;
            }
            carImages.CarImagesPath = FileHelper.Add(file);
            carImages.CarImagesDate = DateTime.Now;
            _carImageDal.Add(carImages);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult Delete(CarImages carImages)
        {
            FileHelper.Delete(carImages.CarImagesPath);
            _carImageDal.Delete(carImages);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CarImagesValidator))]
        public IDataResult<CarImages> Get(int id)
        {
            return new SuccessDataResult<CarImages>(_carImageDal.Get(p => p.CarImagesId == id));
        }

        public IDataResult<List<CarImages>> GetAll()
        {
            return new SuccessDataResult<List<CarImages>>(_carImageDal.GetAll());
        }

        


        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult Update(IFormFile file, CarImages carImage)
        {
            IResult result = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));
            if (result!=null)
            {
                return result;
            }
            carImage.CarImagesPath = FileHelper.Update
                (_carImageDal.Get(p => p.CarImagesId == carImage.CarImagesId).CarImagesPath, file);
            carImage.CarImagesDate = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }


        private IResult CheckImageLimitExceeded(int carId)
        {
            var carImagecount = _carImageDal.GetAll(p => p.CarId == carId).Count;
            if (carImagecount >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }
            return new SuccessResult();
        }
        private List<CarImages> CheckIfCarImageNull(int id)
        {
            string path = @"\Images\logo.jpg";
            var result = _carImageDal.GetAll(c => c.CarId == id).Any();
            if (!result)
            {
                return new List<CarImages> { new CarImages { CarId = id, CarImagesPath = path, CarImagesDate = DateTime.Now } };
            }
            return _carImageDal.GetAll(p => p.CarId == id);
        }

        public IDataResult<List<CarImages>> GetImagesByCarId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
