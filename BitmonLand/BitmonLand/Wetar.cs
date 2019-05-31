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
            ptVida = random.Next(49, 60);
            ptAtaque = random.Next(20, 25);
            Tvida = random.Next(6, 8);
            Edad = 0;
            tipo = "Doti";
            this.Image = BitmonLand.Properties.Resources.Wetar1;
        }

    }
}
