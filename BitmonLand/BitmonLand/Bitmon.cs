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
        private string tipo;
        private string[] bitmonTypes = { "Gofue", "Wetar", "Taplan", "Dorvalo", "Ent" };
        private int mi_posicion;

        public Bitmon()
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
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
                    if (tipo == "Gofue")
                        this.Image = BitmonLand.Properties.Resources.Gofue1;
                    else if (tipo == "Wetar")
                        this.Image = BitmonLand.Properties.Resources.Wetar1;
                    else if (tipo == "Taplan")
                        this.Image = BitmonLand.Properties.Resources.BitmonGhost1;
                    else if (tipo == "Dorvalo")
                        this.Image = BitmonLand.Properties.Resources.Dorvalo1;
                    else if (tipo == "Ent")
                        this.Image = BitmonLand.Properties.Resources.Ent1;
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

        public virtual int Moverse(int columnas, int filas)
        {
            int fila = mi_posicion / filas;
            int col = mi_posicion % columnas;
            // proceso de elegir un numero valido

            int rand_col = 4;
            int rand_fil = 7;

            mi_posicion = rand_fil * columnas + rand_col;
            Casillas[3].Borrar(this);
            return mi_posicion;
        }
    }
}
