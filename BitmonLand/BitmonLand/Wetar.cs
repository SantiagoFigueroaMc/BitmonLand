using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonLand
{
    class Wetar : Bitmon
    {

        public Wetar()
        {
            ptVida = r.Next(49, 60);
            ptAtaque = r.Next(20, 25);
            Tvida = r.Next(5, 7);
            Edad = 0;
        }

    }
}
