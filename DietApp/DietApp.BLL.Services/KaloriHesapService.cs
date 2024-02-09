using DietApp.DAL.Repositories;
using DietApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BLL.Services
{
    public class KaloriHesapService
    {
        OgunRepository _ogunrepo;
        KullaniciKisiselRepository _kkRepository;


        public KaloriHesapService()
        {
            _ogunrepo= new OgunRepository();
            _kkRepository= new KullaniciKisiselRepository();
        }
        public double GunlukKaloriHesabi(int id, DateTime tarih)
        {
            List<KullaniciKisisel> kklist = _kkRepository.GetAll().ToList();
            List<Ogun> ogunlist = _ogunrepo.GetAll().ToList();

            double sayi = 0;

            var query = from k in kklist
                        join o in ogunlist on k.ID equals o.KullaniciKisiselID
                        where k.ID == id && o.Tarih==tarih
                        select new
                        {
                            sayi = o.Kalori
                        };
            foreach (var q in query)
            {
                sayi+= q.sayi;
            }

            return sayi;
        }
    }
}
