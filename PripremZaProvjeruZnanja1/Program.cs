using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremZaProvjeruZnanja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3.2, b = 2.6, c = 7.8, d = 5.9;
            double x = a*2+b*2+c*2+d*2/(a+b)*2+(c+d)*2;

            Console.WriteLine("Vrijednost x je: " + x);

            Console.ReadKey();  
        }
    }
}
