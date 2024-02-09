using DietApp.Entities;
using DietApp.ViewModels;
using DietApp.ViewModels.KullaniciKisiselVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.IServices
{
    public interface IYemekGuncelleService
    {
        public Yemek YemekGetir(int id);
        public YemekMiktari YemekMiktarGetir(int id);
        public Kategori KategoriGetir(int id);
        public int YemekGuncelle(YemekGuncelleVm vm);
       
    }
}
