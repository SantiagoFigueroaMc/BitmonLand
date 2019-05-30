using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmonLand
{
    class Bitmon : PictureBox
    {
        protected int ptVida;
        protected int ptAtaque;
        protected int Edad=0;//temporal
        protected int Tvida=5;// es para que los bitmons iniciales pueddan morir de viejos 
        //(ya que no son de tipo gofue o algo si no tipo bitmon, luego nunca se les definen esos valores y quedan en null)
        protected int CantidadHijos;

        protected string tipo;
        protected string[] bitmonTypes = { "Gofue", "Wetar", "Taplan", "Dorvalo", "Ent", "Doti" };
        protected int mi_posicion;
        protected Random r = new Random();


        public Bitmon()
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

        #region getters y setters

        public void setpocision(int c)
        {
            mi_posicion = c;
        }

        public int getvida()
        {
            return ptVida;
        }

        public int getataque()
        {
            return ptAtaque;
        }

        public int getTvida()
        {
            return Tvida;
        }

        public int getedad()
        {
            return Edad;
        }

        public int getCantHijos()
        {
            return CantidadHijos;
        }

        #endregion

        #region funciones para nacimiento

        public void boostataque(int c)
        {
            ptAtaque += c;
        }

        public void boostvida(int c)
        {
            ptVida += c;
        }

        private void Rejuveneser() // por tener hijo
        {
            int E = Edad;
            Edad -= (int)(0.3 * E);
        }

        public void tenerHijo()
        {
            Rejuveneser();
            CantidadHijos++;
        }

        #endregion

        public void envejecer()
        {
            Edad++;
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                if (bitmonTypes.Contains(value))
                {
                    tipo = value;
                }
            }
        }

        public int Posicion
        {
            get
            {
                return mi_posicion;
            }

            set
            {
                mi_posicion = value;
            }
        }

        public virtual string InteractuarTerreno(string tipo_terreno_pisado)
        {
            // aqui se baja la vida el wn si está parado en algo malo, y devuelve un tipo de terreno aunque no lo cambie.
            return tipo_terreno_pisado;
        }


        public virtual int Moverse(int columnas, int filas)
        {
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
            List<int> caso9 = new List<int>(); //otro caso.
            caso1.Add(0);
            caso1.Add(1);
            caso1.Add(columnas);
            caso1.Add(columnas + 1);
            caso2.Add(0);
            caso2.Add(-1);
            caso2.Add(columnas);
            caso2.Add(columnas - 1);
            caso3.Add(0);
            caso3.Add(1);
            caso3.Add(-columnas);
            caso3.Add(-(columnas - 1));
            caso4.Add(0);
            caso4.Add(-1);
            caso4.Add(-columnas);
            caso4.Add(-(columnas + 1));
            caso5.Add(0);
            caso5.Add(1);
            caso5.Add(columnas);
            caso5.Add(columnas + 1);
            caso5.Add(-columnas);
            caso5.Add(-(columnas - 1));
            caso6.Add(0);
            caso6.Add(-1);
            caso6.Add(columnas);
            caso6.Add(columnas - 1);
            caso6.Add(-columnas);
            caso6.Add(-columnas - 1);
            caso7.Add(0);
            caso7.Add(1);
            caso7.Add(-1);
            caso7.Add(columnas);
            caso7.Add(columnas + 1);
            caso7.Add(columnas - 1);
            caso8.Add(0);
            caso8.Add(1);
            caso8.Add(-1);
            caso8.Add(-columnas);
            caso8.Add(-columnas + 1);
            caso8.Add(-columnas - 1);
            caso9.Add(-(columnas + 1));
            caso9.Add(-columnas);
            caso9.Add(-(columnas - 1));
            caso9.Add(-1);
            caso9.Add(0);
            caso9.Add(1);
            caso9.Add(columnas - 1);
            caso9.Add(columnas);
            caso9.Add(columnas + 1);
            int fila = mi_posicion / filas;
            int col = mi_posicion % columnas;

            if (mi_posicion == 0)
            {
                int movimiento = caso1[rand.Next(caso1.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }

            else if (col == columnas - 1 && mi_posicion == columnas - 1)
            {
                int movimiento = caso2[rand.Next(caso2.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }
            else if (mi_posicion == (columnas * filas) - columnas)
            {
                int movimiento = caso3[rand.Next(caso3.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }
            else if (mi_posicion == (columnas * filas) - 1)
            {
                int movimiento = caso4[rand.Next(caso4.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }
            else if (filas > 2 && col == 0 && mi_posicion != 0 && (mi_posicion != (columnas * filas) - columnas))
            {
                int movimiento = caso5[rand.Next(caso5.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }
            else if ((mi_posicion + 1 / filas) > 1 && mi_posicion != (filas * columnas) - 1 && mi_posicion%filas != 0 && (mi_posicion +1)%columnas == 0)
            {
                int movimiento = caso6[rand.Next(caso6.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }
            else if (col != 0 && mi_posicion > 0 && mi_posicion < columnas)
            {
                int movimiento = caso7[rand.Next(caso7.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }
            else if (col != 0 && (mi_posicion + 1) % columnas != 0 && mi_posicion > (filas * columnas) - columnas && mi_posicion < (filas * columnas) - 1)
            {
                int movimiento = caso8[rand.Next(caso8.Count)];
                posibleMovimiento = mi_posicion + movimiento; ;
                mi_posicion += movimiento;
            }
            else
            {
                int movimiento = caso9[rand.Next(caso9.Count)];
                posibleMovimiento = mi_posicion + movimiento;
                mi_posicion += movimiento;
            }
            //mi_posicion = rand_fil * columnas + rand_col;
            //Casillas[3].Borrar(this);
            return posibleMovimiento;
        }


    }
}
