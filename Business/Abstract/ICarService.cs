﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetCarsBrandId(int id);

        List<Car> GetCarsColorId(int id);

        void Add(Car car);

        void Update(Car car);
        void Delete(Car car);


        List<CarDetailDto> GetCarDetails();
    }
}