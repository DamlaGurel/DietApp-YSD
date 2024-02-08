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
    public interface IYemekGuncellemeService
    {
        List<Yemek> YemekGetir(Kategori kat = null);
        List<Kategori> KategoriGetir();
        int YemekGuncelle(YemekGuncelleVm vm);
    }
}
