using DietApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.ViewModels.Raporlar
{
    public class KiyasRaporOgunVm
    {
        public int OgunAdi { get; set; }
        public int KullaniciId { get; set; }
        public OgunCesitleri Ogun { get; set; }
        public double Kalori { get; set; }
    }
}
