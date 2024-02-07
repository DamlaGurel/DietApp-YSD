using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class GunlukRapor : BesinDegeri
    {
        public DateTime SecilenRaporTarihi { get; set; }
        public string YemekAdi { get; set; }
        public int SuMiktari { get; set; }
        public List<Ogun> GunlukRaporunOgunListesi { get; set; }

    }
}
