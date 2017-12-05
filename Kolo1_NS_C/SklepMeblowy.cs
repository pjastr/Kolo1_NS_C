using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_C
{
    class SklepMeblowy:Sklep
    {
        private char klasa;

        public SklepMeblowy(string p1, int p2, char p3)
            :base(p1,p2)
        {
            this.klasa = p3;
        }

        public bool Dostepnosc(int p1)
        {
            if (p1 >= 0 && p1 <= 14) return true;
            else return false;
        }
    }
}
