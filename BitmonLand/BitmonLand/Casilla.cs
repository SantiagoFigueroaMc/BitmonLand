﻿using System;
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

        public Casilla()
        {
            ocupantes = new List<Bitmon>();
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

        public bool AddOcupante(Bitmon bitmon)
        {
            if (ocupantes.Count() < 2)
            {
                ocupantes.Add(bitmon);
                return true;
            }
            return false;
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
    }
}
