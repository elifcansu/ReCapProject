using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {CarId=1,BrandId=1,ColorId=1,ModelYear="2014",DailyPrice=120,Description="2014 model wolksvagen polo marka  beyaz araba günlük 120 tl'den başlayan fiyatlarla..." },
                new Car
                {CarId=2,BrandId=2,ColorId=1,ModelYear="2012",DailyPrice=150,Description="2012 model Citroen marka  beyaz araba günlük 150 tl'den başlayan fiyatlarla..." },
                 new Car
                {CarId=3,BrandId=1,ColorId=2,ModelYear="2018",DailyPrice=220,Description="2018 model Wolksvagen polo marka kırmızı araba günlük 220 tl'den başlayan fiyatlarla..." },
                  new Car
                {CarId=4,BrandId=3,ColorId=3,ModelYear="2020",DailyPrice=250,Description="2020 model Nissan Qashqai polo marka  beyaz araba günlük 250 tl'den başlayan fiyatlarla..." }

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }
        
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.CarId == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

    }
}
