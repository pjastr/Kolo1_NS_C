using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Sklep s1 = new Sklep("dfdf", 100);
            Sklep s2 = new Sklep("wsz", 1200);
            Supermarket s3 = new Supermarket("wsz", 1200,"dfdf");
            Supermarket s4 = new Supermarket("tgv", 1500, "vghu");
            SklepMeblowy s5 = new SklepMeblowy("dsfdf", 345, 'w');
            SklepMeblowy s6 = new SklepMeblowy("plkjhg", 245, 'r');
            s3.Promocja(4);
            s4.Promocja(6);
            s5.Dostepnosc(56);
            s6.Dostepnosc(11);
            Console.WriteLine(s1.Info());
            Console.WriteLine(s2.Info());
            Console.WriteLine(s3.Info());
            Console.WriteLine(s4.Info());
            Console.WriteLine(s5.Info());
            Console.WriteLine(s6.Info());

            Console.ReadKey();
        }
    }
}
