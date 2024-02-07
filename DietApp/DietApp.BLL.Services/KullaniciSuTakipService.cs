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

            if (su == null) return null;

            Su suTakip = new Su()
            {
                ID = id,
                SuMiktari = su.SuMiktari
            }; return suTakip;
        }

        public int SuEkleUpdate(SuTakipVm vm)
        {
            Su su = _repo.GetByID(vm.ID);

            su.KullaniciKisiselId = vm.ID;
            su.SuMiktari += vm.SuMiktari;

            return _repo.Update(su);
        }

        public int SuCikarUpdate(SuTakipVm vm)
        {
            Su su = _repo.GetByID(vm.ID);

            su.KullaniciKisiselId = vm.ID;
            su.SuMiktari -= vm.SuMiktari;

            return _repo.Update(su);
        }
    }
}
