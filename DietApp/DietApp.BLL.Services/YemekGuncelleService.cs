using DietApp.BLL.IServices;
using DietApp.DAL.IRepositories;
using DietApp.DAL.Repositories;
using DietApp.Entities;
using DietApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class YemekGuncelleService : IYemekGuncelleService
    {

        IOgunRepository _ogunRepo;
        IYemekRepository _yemekRepo;
        IYemekMiktariRepository _yemekMiktariRepo;
        IYemekMiktarOgunRepository _yemekMiktariOgunRepo;
        IKategoriRepository _kategoriRepo;


        public YemekGuncelleService()
        {
            _ogunRepo = new OgunRepository();
            _yemekRepo = new YemekRepository();
            _yemekMiktariRepo = new YemekMiktariRepository();
            _yemekMiktariOgunRepo = new YemekMiktarOgunRepository();
            _kategoriRepo = new KategoriRepository();
        }

        public int YemekGuncelle(YemekGuncelleVm vm)
        {

            YemekMiktari ymk = _yemekMiktariRepo.GetByID(vm.YemekMiktarID);
            ymk.MiktarGr = vm.Miktar;
            ymk.YemekID = vm.YemekID;

            return _yemekMiktariRepo.Update(ymk);
        }
        public int YemekSil(int id)
        {
            return _yemekMiktariRepo.Delete(_yemekMiktariRepo.GetByID(id));
        }

        public Yemek YemekGetir(int id)
        {
            return _yemekRepo.GetByID(id);
        }

        public YemekMiktari YemekMiktarGetir(int id)
        {
            return _yemekMiktariRepo.GetByID(id);
        }
     
        public Kategori KategoriGetir(int id)
        {
            return _kategoriRepo.GetByID(id);
        }

    }
}
