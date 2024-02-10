using DietApp.BLL.IServices;
using DietApp.DAL.Repositories;
using DietApp.Entities;
using DietApp.Enums;
using DietApp.ViewModels;
using DietApp.Entities;
using DietApp.Enums;
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
        KullaniciKisiselRepository _kisiselRepo;

        public RaporlarService()
        {
            _ogunRepo = new OgunRepository();

            _yemekmiktarrepo = new YemekMiktariRepository();
            _yemekOgunRepo = new YemekMiktarOgunRepository();
            _yemekrepo = new YemekRepository();
            _kategoriRepo = new KategoriRepository();
            _kullaniciKisiselRepo = new KullaniciKisiselRepository();
            _kategoriRepo = new KategoriRepository();
            _kisiselRepo = new KullaniciKisiselRepository();
        }

        public List<GunlukRaporVm> GunlukRapor(int id, DateTime gun)
        {
            List<GunlukRaporVm> gunlukRapors = _ogunRepo.GetAll().Where(x => x.KullaniciKisiselID == id && x.Tarih.Date == gun.Date).OrderBy(x => x.OgunAdi).Select(x => new GunlukRaporVm()
            {
                OgunAdi = x.OgunAdi,
                Kalori = x.Kalori
            }).ToList();
            return gunlukRapors;
        }

        public List<KiyasRaporOgunVm> KiyasRaporOgun(DateTime baslangicTarihi, DateTime bitisTarihi)
        {

            List<KiyasRaporOgunVm> kiyasRaporOgun = _ogunRepo.GetAll().Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).Select(s => new KiyasRaporOgunVm()
            {
                OgunAdi = (int)s.OgunAdi,
                KullaniciId = s.KullaniciKisiselID,
                Kalori = s.Kalori
            }).ToList();
            return kiyasRaporOgun;
        }

        public List<KiyasRaporYemekVm> KiyasRaporYemek()
        {
            throw new NotImplementedException();
        }

        public List<Kategori> KategoriGetAll()
        {
            return new KategoriRepository().GetAll().ToList();
        }


        public void KiyasRaporOgun(DateTime baslangicTarih, DateTime bitistarih, Kategori kat, int kisiID, out double GenelOrtalamaKalori, out double KisiOrtalamaKalori)
        {
            var query =
                from kisisel in _kullaniciKisiselRepo.GetAll()
                join ogun in _ogunRepo.GetAll() on kisisel.ID equals ogun.KullaniciKisiselID
                join ymkogun in new YemekMiktarOgunRepository().GetAll() on ogun.ID equals ymkogun.OgunID
                join miktar in new YemekMiktariRepository().GetAll() on ymkogun.YemekMiktarID equals miktar.ID
                join yemek in new YemekRepository().GetAll() on miktar.YemekID equals yemek.ID
                join kategori in new KategoriRepository().GetAll() on yemek.KategoriID equals kategori.ID
                where kat.ID == kategori.ID && ogun.Tarih >= baslangicTarih && ogun.Tarih <= bitistarih
                select new
                {
                    yemek.Kalori
                };



            List<double> genelKategoriler= new List<double>();
            foreach (var kal in query)
            {
                genelKategoriler.Add(kal.Kalori);
            }
            if (genelKategoriler.Count != 0)
                GenelOrtalamaKalori = genelKategoriler.Average();
            else GenelOrtalamaKalori = 0;



            var query2 =
                   from kisisel in _kullaniciKisiselRepo.GetAll()
                   join ogun in _ogunRepo.GetAll() on kisisel.ID equals ogun.KullaniciKisiselID
                   join ymkogun in new YemekMiktarOgunRepository().GetAll() on ogun.ID equals ymkogun.OgunID
                   join miktar in new YemekMiktariRepository().GetAll() on ymkogun.YemekMiktarID equals miktar.ID
                   join yemek in new YemekRepository().GetAll() on miktar.YemekID equals yemek.ID
                   join kategori in new KategoriRepository().GetAll() on yemek.KategoriID equals kategori.ID
                   
                  where kategori.ID == kat.ID && kisisel.ID == kisiID && ogun.Tarih >= baslangicTarih && ogun.Tarih <= bitistarih
                  
                   select new
                   {
                       kalori = yemek.Kalori
                   };


            List<double> KisiKategoriler = new List<double>();
            foreach (var kal in query2)
            {
                KisiKategoriler.Add(kal.kalori);
            }
            if(KisiKategoriler.Count!=0)
            KisiOrtalamaKalori = KisiKategoriler.Average();//query.Average();
            else
                KisiOrtalamaKalori=0;
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
