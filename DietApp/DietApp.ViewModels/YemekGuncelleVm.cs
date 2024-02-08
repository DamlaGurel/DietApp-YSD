using DietApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.ViewModels
{
    public class YemekGuncelleVm
    {
        public Ogun Ogun { get; set; }
        public int YemekID { get; set; }
        public double MiktarGr { get; set; }
        public string OgunAdi { get; set; }
    }
}
