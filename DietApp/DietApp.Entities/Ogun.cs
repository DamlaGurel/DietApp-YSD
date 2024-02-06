using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class Ogun
    {
        public string OgunAdi { get; set; }
        public List<Yemek> YemekListesi { get; set; }
        public DateTime Tarih { get; set; }
        public KullaniciKisisel Kullanici { get; set; }
      
     


    }
}
