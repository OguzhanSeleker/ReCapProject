using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void AddBrand(Brand brand)
        {
            // iş iş iş
            if (brand.Name.Length <= 2)
            {
                Console.WriteLine("Marka adı 2 karakterden küçük olamaz");
            }
            else
            {
                var res = _brandDal.Add(brand);
                if (res)
                {
                    Console.WriteLine("Kayıt başarılı");
                }
                else
                {
                    Console.WriteLine("Kayıt Başarısız");
                }
            }

        }

        public void DeleteBrand(Brand brand)
        {
            var res = _brandDal.Delete(brand);
            if (res)
            {
                Console.WriteLine("Silme başarılı");
            }
            else
            {
                Console.WriteLine("Silme Başarısız");
            }
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.GetById(b => b.Id == id);
        }

        public void UpdateBrand(Brand brand)
        {
            var res = _brandDal.Update(brand);
            if (res)
            {
                Console.WriteLine("Kayıt güncelleme başarılı");
            }
            else
            {
                Console.WriteLine("Kayıt güncelleme Başarısız");
            }
        }
    }
}
