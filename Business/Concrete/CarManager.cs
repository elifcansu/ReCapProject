using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            
            return _carDal.GetAll();
        }

        public List<Car> GetCarsBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 )
            {
                _carDal.Add(car);
                Console.WriteLine("Yeni araç eklendi.");
            }
            else
            {
                Console.WriteLine("Lütfen 0'dan büyük bir değer giriniz.");
            }

        }

        public List<CarDetailDto> GetCarDetails()
        {
            Console.WriteLine("Araba detaylarını inceleyebilirsiniz.");
            return _carDal.GetCarDetails();
            
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araç güncellendi");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araç silindi");
        }
    }
}
