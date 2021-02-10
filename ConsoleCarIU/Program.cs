using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleCarIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.ReadLine();
        }
    }
}
