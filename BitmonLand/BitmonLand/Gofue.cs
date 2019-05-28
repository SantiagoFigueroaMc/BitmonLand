using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonLand
{
    class Gofue : Bitmon
    {
        int ptVida;
        int ptAtaque;
        int Edad;
        int Tvida; 


        public Gofue()
        {
            ptVida = r.Next(40, 60);
            ptAtaque = r.Next(10, 21);
            Tvida = r.Next(4, 7);
            Edad = 0;
        }


    }
}
