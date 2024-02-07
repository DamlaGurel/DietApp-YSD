using DietApp.BLL.IServices;
using DietApp.DAL.IRepositories;
using DietApp.DAL.Repositories;
using DietApp.Entities;
using DietApp.ViewModels.VucutIndeksiVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class VucutIndeksiService : IVucutIndeksiService
    {
        IVucutIndeksiRepository _repo;
        public VucutIndeksiService()
        {
            _repo = new VucutIndeksiRepository();
        }
        public int Create(VucutIndeksiCreateVm vm)
        {
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
                SuMiktari = vm.SuMiktari,
                Yas = vm.Yas,
            }; return _repo.Create(kkVucutIndeksi);

        }

        
        public int Update(VucutIndeksiUpdateVm vm)
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
            kkVucutIndeksi.SuMiktari = vm.SuMiktari;
            kkVucutIndeksi.Yas = vm.Yas;

            return _repo.Update(kkVucutIndeksi);
         
        }

        
        public VucutIndeksiUpdateVm GetByID(int id)
        {
            KullaniciKisisel kkVucutIndeksi = _repo.GetByID(id);

            VucutIndeksiUpdateVm vi = new VucutIndeksiUpdateVm()
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
                SuMiktari = kkVucutIndeksi.SuMiktari,
                Yas = kkVucutIndeksi.Yas,
                ID = id,
            };
            return vi;


        }


        public decimal IdealKiloHesapla(VucutIndeksiVm vm, bool cinsiyet)
        {
            //Erkekler için ideal kilo hesaplama formülü: 50 + 2.3 x((boy(cm) / 2.54) - 60)

            //Kadınlar için ideal kilo hesaplama formülü: 45.5 + 2.3 x((boy(cm) / 2.54) - 60)

            decimal idealKilo;
            if (cinsiyet == false)
            {
                idealKilo = 50M + 2.3M * ((vm.Boy / 2.54M) - 60M);
            }

            else
            {
                idealKilo = 45.5M + 2.3M * ((vm.Boy / 2.54M) - 60M);
            }

            return idealKilo;
        }

        public decimal VucutKitleIndeksiHesapla(VucutIndeksiVm vm)
        {
            //Vücut Kitle İndeksi(VKİ) = kilo / boy x boy
            decimal vucutKitleIndeksi;
            vucutKitleIndeksi = vm.Kilo / vm.Boy * vm.Boy;

            return vucutKitleIndeksi;
        }

        public decimal GunlukKaloriIhtiyaci(VucutIndeksiVm vm)
        {
            //Erkekler için Harris Benedict formülü: 66,5 + (5x Boy(cm)) +(13, 75x Ağırlık(kg)) -(6, 77xYaş)

            //Kadınlar için Harris Benedict formülü: 655,1 + (1, 85x Boy(cm)) +(9, 56x Ağırlık(kg)) -(4, 67xYaş)

            decimal gunlukKalori;
            if (vm.Cinsiyet == false)
            {
                gunlukKalori = 66.5M + (5 * vm.Boy) + (13.75M * vm.HedefKilo) - (6.77M * vm.Yas);
            }
            else
            {
                 gunlukKalori = 655.1M + (1.85M * vm.Boy) + (9.56M * vm.HedefKilo) - (4.67M * vm.Yas);
            }
            return gunlukKalori;
        }
    }
}
