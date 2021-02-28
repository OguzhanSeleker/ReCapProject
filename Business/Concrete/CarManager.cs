using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AddCar(Car car)
        {
            if (car.Description.Length <= 2)
            {
                Console.WriteLine("Arabanın tanımı 2 karakterden kısa olamaz");
            }
            else
            {
                if (car.DailyPrice > 0)
                {
                    _carDal.Add(car);
                    Console.WriteLine("Araba eklendi");
                }
                else
                {
                    Console.WriteLine("Arabanın günlük ücreti 0'dan büyük olmalı");
                }
            }

        }

        public void DeleteCar(Car car)
        {
            var res = _carDal.Delete(car);
            if (res)
            {
                Console.WriteLine("Kayıt silme başarılı");
            }
            else
            {
                Console.WriteLine("kayıt silme başarısız");
            }

        }

        public List<Car> GetAll()
        {
            //işler
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(c => c.Id == id);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetCarsByBrandId(brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetCarsByColorId(colorId);
        }

        public void UpdateCar(Car car)
        {
            var res = _carDal.Update(car);
            if (res)
            {
                Console.WriteLine("Kayıt Güncelleme başarılı");
            }
            else
            {
                Console.WriteLine("Kayıt güncelleme başarısız");
            }
        }


    }
}
