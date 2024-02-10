using DietApp.BLL.IServices;
using DietApp.DAL.Repositories;
using DietApp.Entities;
using DietApp.Enums;
using DietApp.ViewModels;
using DietApp.ViewModels.Raporlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DietApp.BLL.Services
{
    public class RaporlarService : IRaporlarService
    {
        OgunRepository _ogunRepo;
        
        YemekMiktariRepository _yemekmiktarrepo;
        YemekRepository _yemekrepo;
        YemekMiktarOgunRepository _yemekOgunRepo;
        KategoriRepository _kategoriRepo;
        KullaniciKisiselRepository _kullaniciKisiselRepo;
        public RaporlarService()
        {
            _ogunRepo = new OgunRepository();

            _yemekmiktarrepo = new YemekMiktariRepository();
            _yemekOgunRepo = new YemekMiktarOgunRepository();
            _yemekrepo = new YemekRepository();
            _kategoriRepo = new KategoriRepository();
            _kullaniciKisiselRepo = new KullaniciKisiselRepository();
        }

        public List<GunlukRaporVm> GunlukRapor(int id, DateTime gun)
        {
            List<GunlukRaporVm> gunlukRapors = _ogunRepo.GetAll().Where(x => x.KullaniciKisiselID == id && x.Tarih.Date == gun.Date).OrderBy(x => x.OgunAdi).Select(x => new GunlukRaporVm()
            {
                OgunAdi = x.OgunAdi,
                Kalori = x.Kalori
            }).ToList(); return gunlukRapors;
        }

        public List<YemekCesidiRaporuVm> YemekCesidiRapor(int id, string yemek)
        {
            List<YemekMiktari> miktarlar = _yemekmiktarrepo.GetAll().ToList();
            List<Ogun> ogunler = _ogunRepo.GetAll().ToList();
            List<YemekMiktarOgun> yemekmiktarogunler = _yemekOgunRepo.GetAll().ToList();
            List<Yemek> yemekler = _yemekrepo.GetAll().ToList();
         
            List<KullaniciKisisel> kullanicilar = _kullaniciKisiselRepo.GetAll().ToList();

            var ij = from y in yemekler
                      join aratablo in miktarlar on y.ID equals aratablo.YemekID
                      join ara2tablo in yemekmiktarogunler on aratablo.ID equals ara2tablo.YemekMiktarID
                      join ara3tablo in ogunler on ara2tablo.OgunID equals ara3tablo.ID
                      join kullanici in kullanicilar on ara3tablo.KullaniciKisiselID equals kullanici.ID
                      where y.YemekAdi == yemek && kullanici.ID == id
                      select new
                      {
                          ToplamKalori = ara3tablo.Kalori,
                          YemekAdi = y.YemekAdi,
                          Miktar = aratablo.MiktarGr,
                          Ogun = ara3tablo.OgunAdi,
                      };

            
            List<YemekCesidiRaporuVm> vmList = new List<YemekCesidiRaporuVm>();

            foreach (var a in ij)
            {
                YemekCesidiRaporuVm vm = new YemekCesidiRaporuVm()
                {
                    YemekAdi = a.YemekAdi,
                    Kalori = a.ToplamKalori,
                    Miktar = a.Miktar,
                   OgunAdi = a.Ogun,
                };
                vmList.Add(vm);
            }

            return vmList;
        }

       
    }
}
