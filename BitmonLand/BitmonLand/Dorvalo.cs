using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonLand
{
    class Dorvalo : Bitmon
    {

        public Dorvalo()
        {
            ptVida = r.Next(30, 46);
            ptAtaque = r.Next(8, 13);
            Tvida = r.Next(3, 7);
            Edad = 0;
        }

        public override string InteractuarTerreno(string tipo_terreno_pisado)
        {
            if (tipo_terreno_pisado == "agua")
            {
                Edad += 1;
                return tipo_terreno_pisado;
            }
            //else if (tipo_terreno_pisado malo)
            else
            {
                return base.InteractuarTerreno(tipo_terreno_pisado);
            }
        }


    }
}
