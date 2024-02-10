using DietApp.BLL.IServices;
using DietApp.DAL.Repositories;
using DietApp.Entities;
using DietApp.Enums;
using DietApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class YemekMiktariService: IYemekMiktariService
    {
        YemekMiktariRepository _yemekmiktarrepo;
        YemekRepository _yemekrepo;
        OgunRepository _ogunrepo;
        YemekMiktarOgunRepository _yemekOgunRepo;
        KategoriRepository _kategoriRepo;
        KullaniciKisiselRepository _kullaniciKisiselRepo;

        public YemekMiktariService()
        {
            _yemekmiktarrepo = new YemekMiktariRepository();
            _ogunrepo= new OgunRepository();
            _yemekOgunRepo=new YemekMiktarOgunRepository();
            _yemekrepo=new YemekRepository();
            _kategoriRepo=new KategoriRepository();
            _kullaniciKisiselRepo=new KullaniciKisiselRepository();
        }
        public List<YemekListVm> YemekleriGetir(DateTime tarih,OgunCesitleri ogunCesidi,int id=0)
        {

            List<YemekMiktari> miktarlar= _yemekmiktarrepo.GetAll().ToList();
            List<Ogun> ogunler= _ogunrepo.GetAll().ToList();
            List<YemekMiktarOgun> yemekmiktarogunler= _yemekOgunRepo.GetAll().ToList();
            List<Yemek> yemekler= _yemekrepo.GetAll().ToList();
            List<Kategori> kategoriler= _kategoriRepo.GetAll().ToList();
            List<KullaniciKisisel> kullanicilar= _kullaniciKisiselRepo.GetAll().ToList();   

            var query = from miktar in miktarlar
                        join aratablo in yemekmiktarogunler on miktar.ID equals aratablo.YemekMiktarID
                        join ogun in ogunler on aratablo.OgunID equals ogun.ID
                        join yemek in yemekler on miktar.YemekID equals yemek.ID
                        join kategori in kategoriler on yemek.KategoriID equals kategori.ID
                        join kullanici in kullanicilar on ogun.KullaniciKisiselID equals kullanici.ID
                        where ogun.Tarih.Date==tarih.Date && ogun.OgunAdi== ogunCesidi && kullanici.ID==id
                        select new
                        {
                            YemekMiktarID = miktar.ID,
                            KategoriID = kategori.ID,
                            YemekAdi=yemek.YemekAdi,
                            Kalori=yemek.Kalori,
                            Kategori= kategori.KategoriAdi,
                            Karbonhidrat =yemek.KarbonhidratMiktari,
                            Protein=yemek.ProteinMiktari,
                            Yag=yemek.YagMiktari,
                            Miktar=miktar.MiktarGr

                        };

            List < YemekListVm > vmlist= new List < YemekListVm >();

            foreach (var a in query)
            {
                YemekListVm vm=new YemekListVm()
                {
                    YemekMiktarID=a.YemekMiktarID,
                    KategoriID=a.KategoriID,
                    YemekAdi=a.YemekAdi,
                    Kalori=a.Kalori,
                    Kategori=a.Kategori,
                    KarbonhidratMiktari=a.Karbonhidrat,
                    ProteinMiktari=a.Protein,
                    YagMiktari=a.Yag,
                    Miktar=a.Miktar
                };
                vmlist.Add(vm);
            }
            return vmlist;

        }
    }
}
