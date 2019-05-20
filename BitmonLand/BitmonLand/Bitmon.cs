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
        private string[] bitmonTypes = { "Gofue", "Wetar", "Taplan" };

        public Bitmon()
        {

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
    }
}
