using DietApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.ViewModels
{
    public class YemekListVm:BesinDegeri
    {
        public int YemekMiktarID { get; set; }
        public string YemekAdi { get; set; }
        public string Kategori { get; set; }

    }
}
