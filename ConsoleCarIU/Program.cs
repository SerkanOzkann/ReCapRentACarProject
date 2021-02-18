using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleCarIU
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();


            // ColorManagerTest();

          //  BrandManagerTest();



            Console.ReadLine();
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Araç Adı: " + car.CarName + "Araç Fiyatı: " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
