using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void AddColor(Color color)
        {
            if (color.Name.Length <= 2)
            {
                Console.WriteLine("renk ismi 2 karakterden küçük olamaz");
            }
            else
            {
                var res = _colorDal.Add(color);
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

        public void DeleteColor(Color color)
        {
            var res = _colorDal.Delete(color);
            if (res)
            {
                Console.WriteLine("Silme başarılı");
            }
            else
            {
                Console.WriteLine("Silme Başarısız");
            }
        }


        public void UpdateColor(Color color)
        {
            var res = _colorDal.Update(color);
            if (res)
            {
                Console.WriteLine("Kayıt güncelleme başarılı");
            }
            else
            {
                Console.WriteLine("Kayıt güncelleme Başarısız");
            }
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.GetById(c => c.Id == id);
        }
    }
}
