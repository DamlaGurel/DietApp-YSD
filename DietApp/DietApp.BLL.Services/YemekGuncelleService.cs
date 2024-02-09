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

            YemekMiktari ymkMiktar = _yemekMiktariRepo.GetByID(vm.YemekMiktarID);
            Yemek ymk = _yemekRepo.GetByID(vm.YemekID);
            ymkMiktar.MiktarGr = vm.Miktar;
            ymkMiktar.YemekID = vm.YemekID;
            ymkMiktar.Kalori = ymk.Kalori * ymkMiktar.MiktarGr / 100;
            ymkMiktar.KarbonhidratMiktari = ymk.KarbonhidratMiktari * ymkMiktar.MiktarGr / 100;
            ymkMiktar.ProteinMiktari = ymk.ProteinMiktari * ymkMiktar.MiktarGr / 100;
            ymkMiktar.YagMiktari = ymk.YagMiktari * ymkMiktar.MiktarGr / 100;
            return _yemekMiktariRepo.Update(ymkMiktar);
        }
        public int YemekSil(int id)
        {
            YemekMiktari ym = _yemekMiktariRepo.GetByID(id);
            
            Ogun ogun = _ogunRepo.GetByID(new YemekMiktarOgunRepository().GetAll().FirstOrDefault(x => x.YemekMiktarID == ym.ID).OgunID);
            ogun.Kalori -= ym.Kalori;
            ogun.ProteinMiktari -= ym.ProteinMiktari;
            ogun.KarbonhidratMiktari -= ym.KarbonhidratMiktari;
            ogun.YagMiktari -= ym.YagMiktari;

            _ogunRepo.Update(ogun);
            return _yemekMiktariRepo.Delete(ym);
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
