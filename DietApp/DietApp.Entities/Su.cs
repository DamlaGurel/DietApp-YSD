using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class Su : BaseEntity
    {
        public double SuMiktari { get; set; }
        public KullaniciKisisel KullaniciKisisel { get; set; }
        public int KullaniciKisiselId { get; set; }
    }
}
