using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_C
{
    class Supermarket:Sklep
    {
        private string siec;

        public Supermarket(string p1, int p2, string p3)
            :base(p1,p2)
        {
            this.siec = p3;
        }

        public string Promocja(int p1)
        {
            if(p1 % 3==0)
            {
                return "Promocja 30%";
            }
            else
            {
                return "Brak promocji";
            }
        }
    }
}
