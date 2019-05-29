using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmonLand
{
    class Casilla : FlowLayoutPanel
    {
        private List<Bitmon> ocupantes;
        private string tipo;
        private string[] posibles_tipos = { "nieve", "agua", "pasto", "volcan", "arena" };

        public int xy;
        

        public Casilla()
        {
            ocupantes = new List<Bitmon>();
        }

        public List<Bitmon> Ocupantes
        {
            set
            {
                if (value.Count() <= 2)
                {
                    ocupantes = value;
                }
            }
            get
            {
                return ocupantes; 
            }
        }

        public bool AddOcupante(Bitmon bitmon)
        {
            if (ocupantes.Count() < 2)
            {
                ocupantes.Add(bitmon);
                this.Controls.Add(bitmon);
                return true;
            }
            return false;
        }

        // eliminar ocupante
        // ;a necesitaba para avanzar a si que la hizze yo
        public void BorrarOcupante(Bitmon b)
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
                if (posibles_tipos.Contains(value))
                {
                    tipo = value;
                }
            }
        }

        public int ContarOcupantes
        {
            get
            {
                return ocupantes.Count();
            }
        }

    }
}
