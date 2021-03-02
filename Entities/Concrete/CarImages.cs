using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
     public class CarImages:IEntity
    {
        public int CarImagesId { get; set; }
        public int CarId { get; set; }
        public string CarImagesPath { get; set; }
        public DateTime CarImagesDate { get; set; }



    }
}
