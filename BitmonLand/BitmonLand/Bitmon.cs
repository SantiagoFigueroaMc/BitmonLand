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
    }
}
