using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class KullaniciKisisel : BaseEntity
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public bool Cinsiyet { get; set; }
        public int Yas { get; set; }
        public decimal Boy { get; set; }
        public decimal Kilo { get; set; }
        public decimal HedefKilo { get; set; }
        public double GunlukKalori { get; set; }
        public double SuMiktari { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public List<Ogun>? KullanicilarinOgunleri { get; set; }
        public List<Su>? IcilenSu { get; set; }
        public List<GunlukRapor>? KullanicininRaporlari {  get; set; }   
        public  int KullaniciGirisID;
        public KullaniciGiris KullaniciGiris { get; set; }
    }
}
