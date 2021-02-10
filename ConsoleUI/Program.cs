using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTestFirst();

            //BrandTestFirst();

        }

        private static void BrandTestFirst()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "volvo" });
            //brandManager.Delete( new Brand { BrandId=1002});
        }

        private static void CarTestFirst()
        {
            CarManager carManager = new CarManager(new EfCarDal());


            //carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 200, ModelYear = "2018", Description = "Otomatik Dizel" });

            

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine( car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }
        }
    }
}
