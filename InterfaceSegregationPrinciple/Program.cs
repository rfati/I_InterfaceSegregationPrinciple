using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Pants p = new Pants();
            p.Brand = "Mavi";
            p.Fit = "Dar kesim";
            Sweater s = new Sweater();
            s.Collar = "Bakılçı Yaka";
            s.Pattern = "Baklava Desen";
            Console.Write(p.Brand);
            Console.Write(p.Fit);
            Console.Write("\n" + s.Collar);
            Console.Write(s.Pattern);
            Console.Read();
        }
    }
}
