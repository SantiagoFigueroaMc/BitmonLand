﻿using System;
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
            ptVida = random.Next(40, 60);
            ptAtaque = random.Next(10, 21);
            Tvida = random.Next(3, 8);
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
                Trestante += 1;
                return tipo_terreno_pisado;
            }
            //else if (tipo_terreno_pisado malo)
            else
            {
                return tipo_terreno_pisado;
            }
        }

    }
}
