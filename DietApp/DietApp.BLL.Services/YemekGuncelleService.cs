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
    public class YemekGuncelleService : IYemekGuncellemeService
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
            Ogun guncellenmisYemek = new Ogun()
            {
                MiktarGr = vm.MiktarGr,
                YemekID = vm.YemekID,
             };

            return _yemekRepo.Update(guncellenmisYemek);
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
