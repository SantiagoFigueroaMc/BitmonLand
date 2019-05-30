using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonLand
{
    class Doti : Bitmon
    {

        public Doti()
        {
            ptVida = r.Next(100, 500);
            ptAtaque = r.Next(100, 150);
            Tvida = r.Next(2, 5);
            Edad = 0;
            Tipo = "Doti";
            this.Image = BitmonLand.Properties.Resources.Doti1;
        }
        

    }
}
