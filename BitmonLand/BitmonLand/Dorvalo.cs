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
            Tvida = r.Next(4, 8);
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

      /* public override int Moverse(int columnas, int filas)
        {
            int[] casoU = {0, 1, 2, columnas, columnas + 1,
                           columnas+ 2, 2*columnas, (2*columnas) + 1,(2*columnas) + 2};
            int[] casoD = {-2, -1, 0, columnas - 2, columnas - 1,
                           columnas, (2*columnas) - 2, (2*columnas) - 1, 2*columnas};
            int[] casoT = {0, 1, 2, -(columnas - 2), -(columnas - 1),
                           -columnas, -((2*columnas) - 2), -((2*columnas) - 1), -(2*columnas)};
            int[] casoC = {-2, -1, 0, -(columnas + 2), -(columnas + 1),
                           -columnas, -((2*columnas) + 2), -((2*columnas) + 1), -2*columnas};
            int[] casoDi = {-(columnas + 1), -columnas, -(columnas - 1 ), -(columnas - 2), -1, 0,
                           1, 2, columnas-1, columnas, columnas+1, columnas+2, (2*columnas)-1, 2*columnas,
                           (2*columnas)+1, (2*columnas)+2};
            int[] casoOn = {-(columnas+2), -(columnas+1), -columnas, -(columnas-1), -2, -1, 0,
                            1, columnas-2, columnas-1, columnas, columnas+1, (2*columnas)-2,
                            (2*columnas)-1, 2*columnas, (2*columnas)+1};
            int[] casoDo = {-(columnas + 1), -columnas, -(columnas - 1 ), -(columnas - 2), -1, 0,
                           1, 2, columnas-1, columnas, columnas+1, columnas+2, -((2*columnas)-1), -2*columnas,
                           -((2*columnas)+1), -((2*columnas)-2)};
            int[] casoTr = {-((2*columnas)+2), -((2*columnas)+1), -(2*columnas), -((2*columnas)-1), -(columnas+2),
                            -(columnas+1), -columnas, -(columnas-1), -2, -1, 0, 1, columnas-2, columnas-1,
                            columnas, columnas+1};
            int[] casoCi = {-2*columnas, -((2*columnas)-1), -((2*columnas)-2), -columnas, (-columnas)+1,
                            (-columnas)+2, 0, 1, 2, columnas, columnas+1, columnas+2, 2*columnas, (2*columnas)+1,
                            (2*columnas)+2};
            int[] casoSe = {-((2*columnas)+2), -((2*columnas)+1), -(2*columnas), -(columnas+2), -(columnas+1), columnas,
                            -2, -1, 0, columnas-2, columnas-1, columnas, (2*columnas)-2, (2*columnas)-1, 2*columnas};
            int[] casoSi = {-2, -1, 0, 1, 2, columnas-2, columnas-1, columnas, columnas+1, columnas+2, (2*columnas)-2,
                            (2*columnas)-1, 2*columnas, (2*columnas)+1, (2*columnas)+2};
            int[] casoOc = {-2, -1, 0, 1, 2, -(columnas+2), -(columnas+1), -columnas, -(columnas-1), -(columnas-2),
                            -((2*columnas)+2), -((2*columnas)+1), -(2*columnas), -((2*columnas)-1), -((2*columnas)-2),};
            int[] casoNu = { -1, 0, 1, -(columnas + 1), -columnas, -(columnas - 1), columnas + 1, columnas, columnas - 1 };
            Random rand = new Random();
            int posibleMovimiento;
            List<int> caso1 = new List<int>(); //esquina superior izquierda.
            List<int> caso2 = new List<int>(); //esqina superior derecha.
            List<int> caso3 = new List<int>(); //esquina inferior izquierda.
            List<int> caso4 = new List<int>(); //esquina inferior derecha.
            List<int> caso5 = new List<int>(); //bordes de la izquierda.
            List<int> caso6 = new List<int>(); //bordes de la derecha.
            List<int> caso7 = new List<int>(); //borde superior.
            List<int> caso8 = new List<int>(); //borde inferior.
            List<int> caso10 = new List<int>(); //diagonal superior izquierda.
            List<int> caso11 = new List<int>(); //diagonal superior derecha.
            List<int> caso12 = new List<int>(); //diagonal inferior izquierda.
            List<int> caso13 = new List<int>(); //diagonal inferior derecha.
            List<int> caso14 = new List<int>();
            List<int> caso9 = new List<int>(); //otro caso.
            caso1.AddRange(casoU);
            caso2.AddRange(casoD);
            caso3.AddRange(casoT);
            caso4.AddRange(casoC);
            caso5.AddRange(casoCi);
            caso6.AddRange(casoSe);
            caso7.AddRange(casoSi);
            caso8.AddRange(casoOc);
            caso9.AddRange(casoNu);
            caso10.AddRange(casoDi);
            caso11.AddRange(casoOn);
            caso12.AddRange(casoDo);
            caso13.AddRange(casoTr);
            caso14.Add(-1);
            caso14.Add(0);
            caso14.Add(1);

            if (mi_posicion == 0)
            {
                int movimiento = caso1[rand.Next(caso1.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (mi_posicion == (columnas - 1))
            {
                int movimiento = caso2[rand.Next(caso2.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (mi_posicion == ((filas * columnas) - columnas) - 2)
            {
                int movimiento = caso3[rand.Next(caso3.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (mi_posicion == (filas * columnas) - 1)
            {
                int movimiento = caso4[rand.Next(caso4.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if ((mi_posicion / filas) >= 2 && mi_posicion != ((filas * columnas) - columnas) - 2)
            {
                int movimiento = caso5[rand.Next(caso5.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if ((mi_posicion + 1 / filas) > 2 && mi_posicion != (filas * columnas) - 1)
            {
                int movimiento = caso6[rand.Next(caso6.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (mi_posicion > 1 && mi_posicion < columnas - 1)
            {
                int movimiento = caso7[rand.Next(caso7.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (mi_posicion > ((filas * columnas) - columnas) + 1 && mi_posicion < (filas * columnas) - 2)
            {
                int movimiento = caso8[rand.Next(caso8.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (mi_posicion == columnas + 1)
            {
                int movimiento = caso10[rand.Next(caso10.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (mi_posicion == (2 * columnas) - 2)
            {
                int movimiento = caso11[rand.Next(caso11.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (mi_posicion == ((filas * columnas) - (2 * columnas)) + 1)
            {
                int movimiento = caso12[rand.Next(caso12.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (mi_posicion == ((filas * columnas) - columnas) - 2)
            {
                int movimiento = caso13[rand.Next(caso13.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (mi_posicion == ((filas * columnas) - columnas) + 1 || mi_posicion == (filas * columnas) - 2 || mi_posicion == (filas * columnas) - (2 * columnas) || mi_posicion == columnas || mi_posicion == 1 || mi_posicion == columnas - 2 || mi_posicion == (2 * columnas) - 1 || mi_posicion == (filas * columnas) - (columnas + 1))
            {
                int movimiento = caso14[rand.Next(caso14.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else
            {
                int movimiento = caso9[rand.Next(caso9.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }
            return posibleMovimiento;
            //return base.Moverse(columnas, filas);
        }*/

    }
}
