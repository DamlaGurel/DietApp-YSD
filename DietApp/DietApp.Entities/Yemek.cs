using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{

    public class Yemek : BesinDegeri
    {
        public string YemekAdi { get; set; }
        public string FotografYolu { get; set; }
        public virtual Kategori Kategori { get; set; }
        public int KategoriID { get; set; }
        public List<YemekMiktari> YemekMiktarlari { get; set; }
    }
}
