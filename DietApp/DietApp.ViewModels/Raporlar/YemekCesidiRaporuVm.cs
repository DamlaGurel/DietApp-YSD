using DietApp.Entities;
using DietApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.ViewModels.Raporlar
{
    public class YemekCesidiRaporuVm
    {
        public OgunCesitleri OgunAdi { get; set; }
        public double Miktar { get; set; }
        public string YemekAdi { get; set; }
        public double Kalori { get; set; }

    }
}
