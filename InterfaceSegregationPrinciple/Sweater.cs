﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class Sweater : IClothes
    {
        public int ID { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Collar { get; set; }
        public char Size { get; set; }
        public string Pattern { get; set; }
        public string Material { get; set; }

    }
}
