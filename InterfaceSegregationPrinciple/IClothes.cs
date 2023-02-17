using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IClothes
    {
        int ID { get; set; }
        string Color { get; set; }
        double Price { get; set; }
        
        
    }
}
