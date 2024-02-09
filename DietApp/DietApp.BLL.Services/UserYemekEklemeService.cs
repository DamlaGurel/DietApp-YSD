using DietApp.BLL.IServices;
using DietApp.DAL.IRepositories;
using DietApp.DAL.Repositories;
using DietApp.Entities;
using DietApp.Enums;
using DietApp.ViewModels;

namespace DietApp.BLL.Services
{
    public class UserYemekEklemeService : IUserYemekEklemeService
    {
        IOgunRepository _ogunRepo;
        IYemekRepository _yemekRepo;
        IYemekMiktariRepository _yemekMiktariRepo;
        IYemekMiktarOgunRepository _yemekMiktariOgunRepo;
        IKategoriRepository _kategoriRepo;
        public UserYemekEklemeService()
        {
            _ogunRepo = new OgunRepository();
            _yemekRepo = new YemekRepository();
            _yemekMiktariRepo = new YemekMiktariRepository();
            _yemekMiktariOgunRepo = new YemekMiktarOgunRepository();
            _kategoriRepo = new KategoriRepository();
        }

        public Ogun TariheGoreOgunBul(OgunCesitleri cesit, DateTime time, int KullaniciID)
        {
            Ogun ogun = _ogunRepo.GetAll().FirstOrDefault(x => x.Tarih == time && x.OgunAdi == cesit);

            if (ogun == null)
            {
                ogun = new Ogun()
                {
                    OgunAdi = cesit,
                    Tarih = time,
                    KullaniciKisiselID = KullaniciID,
                    KarbonhidratMiktari = 0,
                    ProteinMiktari = 0,
                    Kalori = 0,
                    YagMiktari = 0
                };
                _ogunRepo.Create(ogun);
            }


            return ogun;
        }

        public void UserYemekEkleme(UserYemekEklemePaneliVm userYemekEkleme, Ogun ogun)
        {
            Yemek yemek = _yemekRepo.GetByID(userYemekEkleme.YemekID);

            YemekMiktari yemekMiktari = new YemekMiktari()
            {
                YemekID = userYemekEkleme.YemekID,
                MiktarGr = userYemekEkleme.MiktarGr,
                Kalori = yemek.Kalori * userYemekEkleme.MiktarGr / 100,
                KarbonhidratMiktari = yemek.KarbonhidratMiktari * userYemekEkleme.MiktarGr / 100,
                ProteinMiktari = yemek.ProteinMiktari * userYemekEkleme.MiktarGr / 100,
                YagMiktari = yemek.YagMiktari * userYemekEkleme.MiktarGr / 100,
            };
            _yemekMiktariRepo.Create(yemekMiktari);

            ogun.Kalori += yemekMiktari.Kalori;
            ogun.ProteinMiktari += yemekMiktari.ProteinMiktari;
            ogun.KarbonhidratMiktari += yemekMiktari.KarbonhidratMiktari;
            ogun.YagMiktari += yemekMiktari.YagMiktari;

            YemekMiktarOgun yemekMiktarOgun = new YemekMiktarOgun()
            {
                OgunID = ogun.ID,
                YemekMiktarID = yemekMiktari.ID,

            };

            _ogunRepo.Update(ogun);
            _yemekMiktariOgunRepo.Create(yemekMiktarOgun);
        }

        public List<Yemek> YemekGetir(Kategori kat = null)
        {
            if (kat == null) { return _yemekRepo.GetAll().ToList(); }

            return _yemekRepo.GetAll().Where(x => x.Kategori == kat).ToList();
        }

        public List<Kategori> KategoriGetir()
        {
            return _kategoriRepo.GetAll().ToList();
        }
    }
}
