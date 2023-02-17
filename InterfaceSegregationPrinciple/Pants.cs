using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class Pants : IClothes
    {
        public int ID { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Fit { get; set; }
        public char Size { get; set; }
        public string Pattern { get; set; }
        public string Brand { get; set; }
    }
}
