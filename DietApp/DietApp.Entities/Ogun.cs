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

        public DateTime Tarih { get; set; }
        public int KullaniciKisiselID { get; set; }
        public KullaniciKisisel? KullaniciKisisel { get; set; }
        public List<YemekMiktarOgun>? OgununYemekleri { get; set; }




    }
}
