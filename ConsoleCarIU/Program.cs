using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleCarIU
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();
            //CustomerManagerTest();
            //ColorManagerTest();
            // BrandManagerTest();
            //UserManagerTest();

            //RentalManagerTest();

            //RentalADD();
            //UserAdd();

            Console.ReadLine();
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result1 = userManager.Add(new User { UserFirstName = "Metecan", UserLastName = "Öğün", UserEmail = "Mete123@gmail.com", Password = "Samet1991" });
            if (result1.Success)
            {
                Console.WriteLine(result1.Message);
            }
            else { Console.WriteLine(result1.Message); }
        }

        private static void RentalADD()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 5, RentDate = new DateTime(2020, 02, 19), ReturnDate = new DateTime(2020, 02, 20) });
            Console.WriteLine(result.Message);
        }

        private static void RentalManagerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine("---------Kiralık Listesi-------");

            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.CustomerId);
            }
        }

        private static void UserManagerTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            Console.WriteLine("-------Kullanici Listesi-----" + "\n");

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("Adı: " + user.UserFirstName + "Soyadı: " + user.UserLastName
                    + "Email: " + user.UserEmail + "\n");
            }
        }

        private static void CustomerManagerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine("----Musteri Listesi-------" + "\n");
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName + "\n");
            }
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
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
