using DietApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Entities
{
    public class BesinDegeri : BaseEntity
    {
        public double Kalori { get; set; }
        public double KarbonhidratMiktari { get; set; }
        public double ProteinMiktari { get; set; }
        public double YagMiktari { get; set; }
    }
}
