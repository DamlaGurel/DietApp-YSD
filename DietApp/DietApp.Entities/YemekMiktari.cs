using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class YemekMiktari:BesinDegeri
    {
       
        public double MiktarGr { get; set; }
        public Yemek YenilenYemek { get; set; }
    }
}
