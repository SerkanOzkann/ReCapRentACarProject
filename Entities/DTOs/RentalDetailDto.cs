using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto: IDto
    {
        public int RentalId { get; set; }
        
        
        public int UserId { get; set; }
        public string UserFistName { get; set; }
        public string UserLastName { get; set; }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string  CarName  { get; set; }
        public int ModelYear { get; set; }
        public  int DailyPrice { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }



    }
}
