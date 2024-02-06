using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class KullaniciGiris:BaseEntity
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
