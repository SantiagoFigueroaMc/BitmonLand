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
        int x=0;
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
        // la necesitaba para avanzar a si que la hize yo
        public void BorrarOcupante(Bitmon b)
        {
            ocupantes.Remove(b);
            this.Controls.Remove(b);
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
                    if (tipo == "agua")
                    {
                        BackgroundImage = BitmonLand.Properties.Resources.Agua1;
                    }
                    else if (tipo == "volcan")
                    {
                        BackgroundImage = BitmonLand.Properties.Resources.Volcan1;
                    }
                    else if (tipo == "arena")
                    {
                        BackgroundImage = BitmonLand.Properties.Resources.Arena1;
                    }
                    else if (tipo == "pasto")
                    {
                        BackgroundImage = BitmonLand.Properties.Resources.Pasto1;
                    }
                    else if (tipo == "nieve")
                    {
                        BackgroundImage = BitmonLand.Properties.Resources.Nieve1;
                    }
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
