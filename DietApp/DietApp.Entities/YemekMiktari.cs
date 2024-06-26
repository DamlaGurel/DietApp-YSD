﻿using DietApp.Core;
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

        public int YemekID { get; set; }
        public Yemek YenilenYemek { get; set; }
        public virtual List<YemekMiktarOgun> YemeginOgunleri { get; set; }
    }
}
