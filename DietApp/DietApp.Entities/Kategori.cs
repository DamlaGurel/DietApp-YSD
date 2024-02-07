using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class Kategori : BaseEntity
    {
        public string KategoriAdi { get; set; }
        public List<Yemek> KategorininYemekListesi { get; set; }

        
    }
}
