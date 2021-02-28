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
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, Description = "Sedan toyota", ModelYear=2017},
                new Car{Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 150, Description = "Sedan Mercedes", ModelYear=2020},
                new Car{Id = 3, BrandId = 2, ColorId = 5, DailyPrice = 70, Description = "Hatchback Hyundai", ModelYear=1998},
                new Car{Id = 4, BrandId = 4, ColorId = 3, DailyPrice = 120, Description = "SUV BMW", ModelYear=2008}

            };
        }

        public bool Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
