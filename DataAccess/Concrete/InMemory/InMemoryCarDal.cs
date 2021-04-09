﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{Id=1, BrandId=1, ColorId=101, DailyPrice=200, ModelYear=2016, Description= "Hyundai I7" },
                new Car{Id=2, BrandId=1, ColorId=301, DailyPrice=100, ModelYear=2012, Description= "Renault Clio" },
                new Car{Id=3, BrandId=2, ColorId=101, DailyPrice=100, ModelYear=2010, Description= "Ford Focus" },
                new Car{Id=4, BrandId=2, ColorId=201, DailyPrice=200, ModelYear=2018, Description= "Renault Clio" },
                new Car{Id=5, BrandId=1, ColorId=201, DailyPrice=1400, ModelYear=2021, Description= "BMW 1.6i" },
                new Car{Id=6, BrandId=4, ColorId=101, DailyPrice=150, ModelYear=2019, Description= "Hyundai Elantra" },
                new Car{Id=7, BrandId=3, ColorId=301, DailyPrice=200, ModelYear=2015, Description= "Renault Megane" },
                new Car{Id=8, BrandId=4, ColorId=101, DailyPrice=300, ModelYear=2013, Description= "Volkswagen Passat" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

    }
}
