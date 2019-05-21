using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmonLand
{
    class Casilla : PictureBox
    {
        private List<Bitmon> ocupantes;

        public Casilla()
        {
        }

        public List<Bitmon> OcupantesSetter
        {
            set
            {
                if (value.Count() <= 2)
                {
                    ocupantes = value;
                }
            }
        }

        public void AddOcupante(Bitmon bitmon)
        {
            if (ocupantes.Count() < 2)
            {
                ocupantes.Add(bitmon);
            }
        }
    }
}
