using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{

    public class Yemek : BaseEntity
    {
        public string YemekAdi { get; set; }

        public virtual Kategori Kategori { get; set; }

        public int KategoriID { get; set; }

        public double Karbonhidrat { get; set; }
        public double Yag { get; set; }
        public double Protein { get; set; }

        public double Kalori { get; set; }
        public virtual List<YemekOgun> YemeginOgunleri { get; set; }

    }
}
