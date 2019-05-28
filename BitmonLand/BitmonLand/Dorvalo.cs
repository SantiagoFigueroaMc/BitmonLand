using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonLand
{
    class Dorvalo : Bitmon
    {
        int ptVida;
        int ptAtaque;
        int Edad;
        int Tvida;

        public Dorvalo()
        {
            ptVida = r.Next(30, 46);
            ptAtaque = r.Next(8, 13);
            Tvida = r.Next(3, 7);
            Edad = 0;
        }


    }
}
