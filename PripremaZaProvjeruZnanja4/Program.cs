using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaProvjeruZnanja4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.4");
            Console.WriteLine("Unesite cijeli i decimalni broj odvojene razmakom: ");
            string sX = Console.ReadLine();
            int posX = sX.IndexOf(' ');
            string s1X = sX.Substring(0, posX);
            int xX = Convert.ToInt32(s1X) * 2;
            double yX = Convert.ToDouble(sX.Substring(posX + 1)) * 2;
            Console.WriteLine("{0} {1}", xX, yX);
        }
    }
}
