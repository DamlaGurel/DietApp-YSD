using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class YemekMiktarOgun : BaseEntity
    {
        public int YemekMiktarID { get; set; }
        public int OgunID { get; set; }
        public YemekMiktari? Yemek { get; set; }
        public Ogun? Ogun { get; set; }
    }
}
