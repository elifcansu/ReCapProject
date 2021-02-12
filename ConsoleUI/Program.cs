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

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 1, CompanyName = "M1 Müşteri" });

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

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
