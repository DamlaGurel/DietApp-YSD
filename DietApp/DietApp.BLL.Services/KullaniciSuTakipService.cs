using DietApp.BLL.IServices;
using DietApp.DAL.IRepositories;
using DietApp.DAL.Repositories;
using DietApp.Entities;
using DietApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class KullaniciSuTakipService : IKullaniciSuTakipService
    {
        IKullaniciSuTakipRepository _repo;
        public KullaniciSuTakipService()
        {
            _repo = new KullaniciSuTakipRepository();
        }

        public int Create(SuTakipVm vm)
        {
            Su su = new Su()
            {
                KullaniciKisiselId = vm.ID,
                SuMiktari = vm.SuMiktari
            }; return _repo.Create(su);
        }

        public Su GetById(int id)
        {
            Su su = _repo.GetByID(id);

            return su;
        }

        public int SuEkleUpdate(SuTakipVm vm)
        {
            Su su = _repo.GetByID(vm.ID);
            su.SuMiktari += vm.SuMiktari;

            return _repo.Update(su);
        }

        public Su SuKontrol(int kkID, DateTime tarih)
        {

            Su aranansu = _repo.GetAll().ToList().FirstOrDefault(x => x.KullaniciKisiselId == kkID && x.Tarih == tarih);

            if (aranansu == null)
            {
                aranansu = new Su() { KullaniciKisiselId = kkID, Tarih = tarih };
                _repo.Create(aranansu);
            }

            return aranansu;
        }

        public int SuCikarUpdate(SuTakipVm vm)
        {
            Su su = _repo.GetByID(vm.ID);

            if (su.SuMiktari > vm.SuMiktari)
                su.SuMiktari -= vm.SuMiktari;
            return _repo.Update(su);
        }
    }
}
