using DietApp.BLL.IServices;
using DietApp.DAL.IRepositories;
using DietApp.DAL.Repositories;
using DietApp.Entities;
using DietApp.ViewModels.KullaniciKisiselVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class KullaniciKisiselService : IKullaniciKisiselService
    {
        IKullaniciKisiselRepository _repo;
        IUserRepository _KGrepo;

        public KullaniciKisiselService()
        {
            _repo = new KullaniciKisiselRepository();
            _KGrepo = new UserRepository();
        }

        public int Create(KullaniciKisiselCreateVm vm)
        {
            KullaniciGiris kullaniciGiris = _KGrepo.GetByID(vm.KullaniciGirisId);

            KullaniciKisisel kkVucutIndeksi = new KullaniciKisisel()
            {
                BaslangicTarihi = vm.BaslangicTarihi,
                BitisTarihi = vm.BitisTarihi,
                Boy = vm.Boy,
                Cinsiyet = vm.Cinsiyet,
                GunlukKalori = vm.GunlukKalori,
                HedefKilo = vm.HedefKilo,
                Isim = vm.Isim,
                Kilo = vm.Kilo,
                Soyisim = vm.Soyisim,
                HedefSuMiktari = vm.SuMiktari,
                Yas = vm.Yas,
                KullaniciGirisID = vm.KullaniciGirisId,
            };


            int kkId = _repo.Create(kkVucutIndeksi);

            kullaniciGiris.KullaniciKisiselID= kkId;

            _KGrepo.Update(kullaniciGiris);

            return kkId;

        }


        public int Update(KullaniciKisiselUpdateVm vm)
        {
            KullaniciKisisel kkVucutIndeksi = _repo.GetByID(vm.ID);

            kkVucutIndeksi.BaslangicTarihi = vm.BaslangicTarihi;
            kkVucutIndeksi.BitisTarihi = vm.BitisTarihi;
            kkVucutIndeksi.Boy = vm.Boy;
            kkVucutIndeksi.Cinsiyet = vm.Cinsiyet;
            kkVucutIndeksi.GunlukKalori = vm.GunlukKalori;
            kkVucutIndeksi.HedefKilo = vm.HedefKilo;
            kkVucutIndeksi.Isim = vm.Isim;
            kkVucutIndeksi.Kilo = vm.Kilo;
            kkVucutIndeksi.Soyisim = vm.Soyisim;
            kkVucutIndeksi.HedefSuMiktari = vm.SuMiktari;
            kkVucutIndeksi.Yas = vm.Yas;

            return _repo.Update(kkVucutIndeksi);

        }


        public KullaniciKisiselUpdateVm GetByID(int id)
        {
            KullaniciKisisel kkVucutIndeksi = _repo.GetByID(id);

            KullaniciKisiselUpdateVm vi = new KullaniciKisiselUpdateVm()
            {
                BaslangicTarihi = kkVucutIndeksi.BaslangicTarihi,
                BitisTarihi = kkVucutIndeksi.BitisTarihi,
                Boy = kkVucutIndeksi.Boy,
                Cinsiyet = kkVucutIndeksi.Cinsiyet,
                GunlukKalori = kkVucutIndeksi.GunlukKalori,
                HedefKilo = kkVucutIndeksi.HedefKilo,
                Isim = kkVucutIndeksi.Isim,
                Kilo = kkVucutIndeksi.Kilo,
                Soyisim = kkVucutIndeksi.Soyisim,
                SuMiktari = kkVucutIndeksi.HedefSuMiktari,
                Yas = kkVucutIndeksi.Yas,
                ID = id,
            };
            return vi;


        }


        public double IdealKiloHesapla(KullaniciKisiselVm vm, bool cinsiyet)
        {
            //Erkekler için ideal kilo hesaplama formülü: 50 + 2.3 x((boy(cm) / 2.54) - 60)

            //Kadınlar için ideal kilo hesaplama formülü: 45.5 + 2.3 x((boy(cm) / 2.54) - 60)

            double idealKilo;
            if (cinsiyet == false)
            {
                idealKilo = 50.0 + 2.3 * ((vm.Boy / 2.54) - 60.0);
            }

            else
            {
                idealKilo = 45.5 + 2.3 * ((vm.Boy / 2.54) - 60.0);
            }

            return idealKilo;
        }

        public double VucutKitleIndeksiHesapla(KullaniciKisiselVm vm)
        {
            //Vücut Kitle İndeksi(VKİ) = kilo / boy x boy
            double vucutKitleIndeksi;
            vucutKitleIndeksi = vm.Kilo / vm.Boy * vm.Boy;

            return vucutKitleIndeksi;
        }

        public double GunlukKaloriIhtiyaci(KullaniciKisiselVm vm)
        {
            //Erkekler için Harris Benedict formülü: 66,5 + (5x Boy(cm)) +(13, 75x Ağırlık(kg)) -(6, 77xYaş)

            //Kadınlar için Harris Benedict formülü: 655,1 + (1, 85x Boy(cm)) +(9, 56x Ağırlık(kg)) -(4, 67xYaş)

            double gunlukKalori;
            if (vm.Cinsiyet == false)
            {
                gunlukKalori = 66.5 + (5 * vm.Boy) + (13.75 * vm.HedefKilo) - (6.77 * vm.Yas);
            }
            else
            {
                gunlukKalori = 655.1 + (1.85 * vm.Boy) + (9.56 * vm.HedefKilo) - (4.67 * vm.Yas);
            }
            return gunlukKalori;
        }
        public KullaniciKisiselSuTakipVm GetByIdKisiselSuTakipVm(int id)
        {
            KullaniciKisisel kullaniciKisisel = _repo.GetByID(id);

            KullaniciKisiselSuTakipVm kisiselSuTakip = new KullaniciKisiselSuTakipVm()
            {
                HedefSuMiktari = kullaniciKisisel.HedefSuMiktari,
            }; return kisiselSuTakip;
        }
    }
}
