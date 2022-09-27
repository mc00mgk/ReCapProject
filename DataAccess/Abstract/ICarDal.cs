using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Araba> GetAll();
        void Ekle(Araba arabası);
        void Güncelleme(Araba arabası);
        void Sil(Araba arabası);
        List<Araba> GetAllById(int carId);

    }
}
