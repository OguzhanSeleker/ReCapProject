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
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = AddBrand(brandManager);
            Color color1 = AddColor(colorManager);
            AddCar(carManager, brand1, color1);
            foreach (var carDetail in carManager.GetCarDetails())
            {
                Console.WriteLine(carDetail.CarName + " / " + carDetail.BrandName + " / " + carDetail.ColorName + " / " + carDetail.DailyPrice);
            }
            //GetAllCar(carManager);
        }

        private static Brand AddBrand(BrandManager brandManager)
        {
            Brand brand1 = new Brand
            {
                AddedDate = DateTime.Now,
                Name = "Hyundai"
            };
            brandManager.AddBrand(brand1);
            return brand1;
        }

        private static Color AddColor(ColorManager colorManager)
        {
            Color color1 = new Color
            {
                AddedDate = DateTime.Now,
                Name = "Gri"
            };
            colorManager.AddColor(color1);
            return color1;
        }

        private static void AddCar(CarManager carManager, Brand brand1, Color color1)
        {
            Car car = new Car
            {
                Brand = brand1,
                Color = color1,
                DailyPrice = 100,
                Description = "Hyundai Accent",
                AddedDate = DateTime.Now,
                ModelYear = 1998
            };
            carManager.AddCar(car);
        }

        private static void GetAllCar(CarManager carManager)
        {
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Id + " --> " + item.Description);
            }
        }
    }
}
