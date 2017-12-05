using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_C
{
    class Sklep
    {
        protected string adres;
        protected int iloscTowarow;

        public Sklep(string p1, int p2)
        {
            this.adres = p1;
            this.iloscTowarow = p2;
        }

        public string Info()
        {
            return adres + ";" + iloscTowarow;
        }
    }
}
