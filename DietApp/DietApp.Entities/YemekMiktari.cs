using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class YemekMiktari:BaseEntity
    {
        public double Karbonhidrat { get; set; }
        public double Yag { get; set; }
        public double Protein { get; set; }
        public double Kalori { get; set; }
        public double MiktarGr { get; set; }
        public Yemek YenilenYemek { get; set; }
    }
}
