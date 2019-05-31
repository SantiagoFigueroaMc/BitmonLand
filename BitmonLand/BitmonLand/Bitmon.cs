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
        protected int Edad=0;//representa el tiempo vivido
        protected int Trestante = 0;//cuando sea igual a Tvida morira de viejo
        //es solo para simplificar las estadisticas
        protected int Tvida=5;// es para que los bitmons iniciales puedan morir de viejos 
        //(ya que no son de tipo gofue o algo si no tipo bitmon, luego nunca se les definen esos valores y quedan en null)
        //solucionado.
        protected int CantidadHijos;

        protected string tipo;
        protected string[] bitmonTypes = { "Gofue", "Wetar", "Taplan", "Dorvalo", "Ent", "Doti" };
        protected int mi_posicion;
        protected Random random = new Random();


        public Bitmon()
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

        #region getters y setters

        public void setpocision(int c)
        {
            mi_posicion = c;
        }

        public int gettrestante()
        {
            return Trestante;
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

        private void Rejuveneser() // por tener hijo recuperan un 30% del tiempo de vida gastado
        {
            int E = Trestante;
            Trestante -= (int)(0.3 * E);
        }

        public void tenerHijo()
        {
            Rejuveneser();
            CantidadHijos++;
        }

        #endregion

        public void envejecer()
        {
            Trestante++;
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
            // Este es un movimiento para las 8 casillas inmediatas

            int posibleMovimiento = mi_posicion;
            int c = mi_posicion % columnas;
            int f = (int)mi_posicion / filas;

            List<int> opciones = new List<int>();

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
