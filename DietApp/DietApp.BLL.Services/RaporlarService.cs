using DietApp.BLL.IServices;
using DietApp.DAL.Repositories;
using DietApp.Enums;
using DietApp.ViewModels.Raporlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class RaporlarService : IRaporlarService
    {
        OgunRepository _ogunRepo;

        public RaporlarService()
        {
            _ogunRepo = new OgunRepository();
        }

        public List<GunlukRaporVm> GunlukRapor(int id, DateTime gun)
        {
            List<GunlukRaporVm> gunlukRapors = _ogunRepo.GetAll().Where(x => x.KullaniciKisiselID == id && x.Tarih.Date == gun.Date).OrderBy(x => x.OgunAdi).Select(x => new GunlukRaporVm()
            {
                OgunAdi = x.OgunAdi,
                Kalori = x.Kalori
            }).ToList(); 
            return gunlukRapors;
        }

        public List<KiyasRaporOgunVm> KiyasRaporOgun(DateTime baslangicTarihi, DateTime bitisTarihi, OgunCesitleri ogun)
        {

            List<KiyasRaporOgunVm> kiyasRaporOgun = _ogunRepo.GetAll().Where(x => x.Tarih >= baslangicTarihi && x.Tarih <= bitisTarihi).Select(s => new KiyasRaporOgunVm()
            {
                OgunAdi = (int)s.OgunAdi,
                KullaniciId = s.KullaniciKisiselID,
                Kalori = s.Kalori
            }).ToList(); 
            return kiyasRaporOgun;
        }

        public List<KiyasRaporYemekVm> KiyasRaporYemek()
        {
            throw new NotImplementedException();
        }
    }
}
