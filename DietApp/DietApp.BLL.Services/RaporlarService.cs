using DietApp.BLL.IServices;
using DietApp.DAL.Repositories;
using DietApp.Entities;
using DietApp.ViewModels.Raporlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class RaporlarService : IRaporlarService
    {
        OgunRepository _ogunRepo;
        KategoriRepository _kategoriRepo;
        KullaniciKisiselRepository _kisiselRepo;

        public RaporlarService()
        {
            _ogunRepo = new OgunRepository();
            _kategoriRepo = new KategoriRepository();
            _kisiselRepo = new KullaniciKisiselRepository();
        }

        public List<GunlukRaporVm> GunlukRapor(int id, DateTime gun)
        {
            List<GunlukRaporVm> gunlukRapors = _ogunRepo.GetAll().Where(x => x.KullaniciKisiselID == id && x.Tarih.Date == gun.Date).OrderBy(x => x.OgunAdi).Select(x => new GunlukRaporVm()
            {
                OgunAdi = x.OgunAdi,
                Kalori = x.Kalori
            }).ToList(); return gunlukRapors;
        }

        public List<Kategori> KategoriGetAll()
        {
            return new KategoriRepository().GetAll().ToList();
        }


        public void KiyasRaporOgun(DateTime baslangicTarih, DateTime bitistarih, Kategori kat, int kisiID, out double GenelOrtalamaKalori, out double KisiOrtalamaKalori)
        {
            List<double> query = (List<double>)
                from kisisel in _kisiselRepo.GetAll()
                join ogun in _ogunRepo.GetAll() on kisisel.ID equals ogun.KullaniciKisiselID
                join ymkogun in new YemekMiktarOgunRepository().GetAll() on ogun.ID equals ymkogun.OgunID
                join miktar in new YemekMiktariRepository().GetAll() on ymkogun.YemekMiktarID equals miktar.ID
                join yemek in new YemekRepository().GetAll() on miktar.YemekID equals yemek.ID
                join kategori in new KategoriRepository().GetAll() on yemek.KategoriID equals kategori.ID
                where kategori == kat
                select new
                {
                    kalori = yemek.Kalori
                };
            GenelOrtalamaKalori = query.Average();

            query = (List<double>)
                from kisisel in _kisiselRepo.GetAll()
                join ogun in _ogunRepo.GetAll() on kisisel.ID equals ogun.KullaniciKisiselID
                join ymkogun in new YemekMiktarOgunRepository().GetAll() on ogun.ID equals ymkogun.OgunID
                join miktar in new YemekMiktariRepository().GetAll() on ymkogun.YemekMiktarID equals miktar.ID
                join yemek in new YemekRepository().GetAll() on miktar.YemekID equals yemek.ID
                join kategori in new KategoriRepository().GetAll() on yemek.KategoriID equals kategori.ID
                where kategori == kat && kisisel.ID == kisiID
                select new
                {
                    kalori = yemek.Kalori
                };
            KisiOrtalamaKalori = query.Average();
        }
    }
}
