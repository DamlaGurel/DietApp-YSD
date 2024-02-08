using DietApp.Entities;
using DietApp.ViewModels;
using DietApp.ViewModels.VucutIndeksiVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.IServices
{
    public interface IYemekGuncelleService
    {
        Yemek YemekGetir(int id);
        YemekMiktari YemekMiktarGetir(int id);
        Kategori KategoriGetir(int id);
        int YemekGuncelle(YemekGuncelleVm vm);
       

    }
}
