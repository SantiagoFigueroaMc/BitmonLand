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
            ptVida = random.Next(50, 100);
            ptAtaque = random.Next(8, 15);
            Tvida = random.Next(5, 8);
            Edad = 0;
            tipo = "Taplan";
            this.Image = BitmonLand.Properties.Resources.Taplan1;
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
            else if (tipo_terreno_pisado == "volcan")
            {
                Edad += 1;
                return tipo_terreno_pisado;
            }

            else
            {
                return tipo_terreno_pisado;
            }
        }

    }
}
