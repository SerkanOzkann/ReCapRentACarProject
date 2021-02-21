using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;

using System.Text;

namespace Business.Abstract
{
   public interface IColorService
    {
        IDataResult<List<Color>> GetAll();

        IDataResult<List<Color>> GetAllById(int ColorId);

        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
        object Update(System.Drawing.Color color);
    }
}
