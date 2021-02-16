using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
   public class CarDetailDto:IDto
    {
        //CarName, BrandName, ColorName, DailyPrice.

        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int    DailyPrice { get; set; }

    }
}
