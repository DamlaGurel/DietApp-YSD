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
    public class KullaniciKisiselService : IKullaniciKisiselService
    {
        IKullaniciKisiselRepository _repo;

        public KullaniciKisiselService()
        {
            _repo = new KullaniciKisiselRepository();
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
