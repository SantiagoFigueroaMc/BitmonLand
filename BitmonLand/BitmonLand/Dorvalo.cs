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
            ptVida = random.Next(30, 46);
            ptAtaque = random.Next(8, 13);
            Tvida = random.Next(4, 8);
            Edad = 0;
            tipo = "Dorvalo";
            this.Image = BitmonLand.Properties.Resources.Dorvalo1;
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

        public override int Moverse(int columnas, int filas)
          {


              int posibleMovimiento = mi_posicion;
              int c = mi_posicion % columnas;
              int f = (int)mi_posicion / filas;

              List<int> opciones = new List<int>();

              // Este es un movimiento para las 8 casillas inmediatas
              if (f > 0 && c > 0)
                 opciones.Add((f - 1) * columnas + (c - 1)) ; // izquierda arriba
              if (c > 0)
                  opciones.Add(f * columnas + (c - 1)); // izquierda centro
              if (f > 0)
                  opciones.Add((f - 1) * columnas + c); // centro arriba
              if (f < filas - 1 && c < columnas - 1)
                  opciones.Add((f + 1) * columnas + (c + 1)); // derecha abajo
              if (c < columnas - 1)
                  opciones.Add(f * columnas + (c + 1)); // derecha centro
              if (f < filas - 1)
                  opciones.Add((f + 1) * columnas + c); // centro abajo
              if (f < filas - 1 && c > 0)
                  opciones.Add((f + 1) * columnas + (c - 1)); // izquierda abajo
              if (f > 0 && c < columnas - 1)
                  opciones.Add((f - 1) * columnas + (c + 1)); // derecha arriba
              

              return opciones.ElementAt(random.Next(opciones.Count));
          }

    }
}
