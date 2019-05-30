using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmonLand
{
    class Gofue : Bitmon
    {

        public Gofue()
        {
            ptVida = r.Next(40, 60);
            ptAtaque = r.Next(10, 21);
            Tvida = r.Next(5, 8);
            Edad = 0;
            tipo = "Gofue";
            this.Image = BitmonLand.Properties.Resources.Gofue1;
        }

        public override string InteractuarTerreno(string tipo_terreno_pisado)
        {
            if (tipo_terreno_pisado == "pasto")
            {
                return "arena";
            }

            else if(tipo_terreno_pisado == "nieve")
            {
               
                return "agua";
            }
            else if (tipo_terreno_pisado == "agua")
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
