using DietApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class Ogun : BesinDegeri
    {
        public OgunCesitleri OgunAdi { get; set; }
        //public List<Yemek> YemekListesi { get; set; }
        public DateTime Tarih { get; set; }
        //public List<KullaniciKisisel> OgunlerinKullanicilari { get; set; }
        //public List<YemekOgun> OgununYemekleri { get; set; }




    }
}
