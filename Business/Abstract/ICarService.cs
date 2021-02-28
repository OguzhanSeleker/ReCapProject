using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Car car);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailsDto> GetCarDetails();

    }
}
