using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspitZnanja3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molimo Vas da upišete neku rečenicu: ");
            string s1 = Console.ReadLine();
            string[] s2 = s1.Split();
            Console.WriteLine(s2.First()+""+s2.Last());

            Console.ReadKey();  
        }
    }
}
