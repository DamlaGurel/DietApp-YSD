using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class YemekOgun : BaseEntity
    {
        public int YemekID { get; set; }
        public int OgunID { get; set; }
        public Yemek Yemek { get; set; }
        public Ogun Ogun { get; set; }
    }
}
