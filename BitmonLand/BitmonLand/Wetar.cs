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
            Tvida = random.Next(8, 10);
            Edad = 0;
            tipo = "Wetar";
            this.Image = BitmonLand.Properties.Resources.Wetar1;
        }

    }
}
