using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonLand
{
    class Taplan : Bitmon
    {

        public Taplan()
        {
            ptVida = r.Next(50, 70);
            ptAtaque = r.Next(8, 13);
            Tvida = r.Next(5, 8);
            Edad = 0;
            this.Image = BitmonLand.Properties.Resources.BitmonGhost1;
        }

        public override string InteractuarTerreno(string tipo_terreno_pisado)
        {
            if (tipo_terreno_pisado == "arena")
            {
                return "pasto";
            }

            else if (tipo_terreno_pisado == "nieve")
            {
                Edad += 1;
                return tipo_terreno_pisado;
            }

            else
            {
                return base.InteractuarTerreno(tipo_terreno_pisado);
            }
        }

    }
}
