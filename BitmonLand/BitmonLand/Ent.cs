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
            ptVida = random.Next(2000, 2500);
            ptAtaque = random.Next(1, 5);
            Tvida = random.Next(7, 10);
            Edad = 0;
            tipo = "Ent";
            this.Image = BitmonLand.Properties.Resources.Ent1;
        }

        public override int Moverse(int columnas, int filas)
        {
            return mi_posicion;
        }
        
    }
}
