using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonLand
{
    class Ent:Bitmon 
    {

        public Ent()
        {
            ptVida = r.Next(2000, 2500);
            ptAtaque = r.Next(1, 5);
            Tvida = r.Next(3, 5);
            Edad = 0;
            this.Image = BitmonLand.Properties.Resources.Ent1;
        }

        public override int Moverse(int columnas, int filas)
        {
            return 0;
        }
        
    }
}
