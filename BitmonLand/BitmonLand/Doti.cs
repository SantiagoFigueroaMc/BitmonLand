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
            ptVida = random.Next(100, 500);
            ptAtaque = random.Next(100, 150);
            Tvida = random.Next(3, 6);
            Edad = 0;
            Tipo = "Doti";
            this.Image = BitmonLand.Properties.Resources.Doti1;
        }
        

    }
}
