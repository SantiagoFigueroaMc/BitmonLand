using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonLand
{
    class Ent:Bitmon 
    {
        int ptVida;
        int ptAtaque;
        int Edad;
        int Tvida;

        public Ent()
        {
            ptVida = r.Next(2000, 2500);
            ptAtaque = r.Next(1, 5);
            Tvida = r.Next(3, 5);
            Edad = 0;
        }
    }
}
