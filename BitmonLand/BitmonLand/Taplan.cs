using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonLand
{
    class Taplan : Bitmon
    {
        int ptVida;
        int ptAtaque;
        int Edad;
        int Tvida;

        public Taplan()
        {
            ptVida = r.Next(50, 70);
            ptAtaque = r.Next(8, 13);
            Tvida = r.Next(5, 8);
            Edad = 0;
        }

    }
}
