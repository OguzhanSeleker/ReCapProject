using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, AppDbContext>, ICarDal
    {
        public List<Car> GetCarsByBrandId(int brandId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Car>().Where(c => c.BrandId == brandId).ToList();
            }
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Car>().Where(c => c.ColorId == colorId).ToList();
            }
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join co in context.Colors on c.ColorId equals co.Id
                             select new CarDetailsDto
                             {
                                 CarName = c.Description,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
