using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmonLand
{
    public partial class Estadisticas : Form
    {
        // Los atributos de esta clase son las estadisticas que se van a guardar en el programa principal
        // Tiempo de vida promedio de los Bitmons.
        decimal tiempo_vida_promedio;
        public decimal TiempoVidaPromedio
        {
            get
            {
                return tiempo_vida_promedio;
            }
            set
            {
                tiempo_vida_promedio = value;
            }
        }


        // Tiempo de vida promedio de cada especie de Bitmon.
        Dictionary<string, decimal> tiempo_vida_promedio_especie = new Dictionary<string, decimal>()
        {
            { "Gofue", 0 },
            { "Taplan", 0 },
            { "Doti", 0 },
            { "Ent", 0 },
            { "Dorvalo", 0 },
            { "Wetar", 0 }
        };
        public Dictionary<string, decimal> TiempoVidaPromedioEspecie
        {
            get
            {
                return tiempo_vida_promedio_especie;
            }
            set
            {
                tiempo_vida_promedio_especie = value;
            }
        }

        // Tasa bruta de natalidad de cada especie.
        Dictionary<string, decimal> tasa_bruta_natalidad_especie = new Dictionary<string, decimal>()
        {
            { "Gofue", 0 },
            { "Taplan", 0 },
            { "Doti", 0 },
            { "Ent", 0 },
            { "Dorvalo", 0 },
            { "Wetar", 0 }
        };
        public Dictionary<string, decimal> TasaBrutaNatalidadEspecie
        {
            get
            {
                return tasa_bruta_natalidad_especie;
            }
            set
            {
                tasa_bruta_natalidad_especie = value;
            }
        }

        // Tasa bruta de mortalidad.
        decimal tasa_bruta_mortalidad;
        public decimal TasaBrutaMortalidad
        {
            get
            {
                return tasa_bruta_mortalidad;
            }
            set
            {
                tasa_bruta_mortalidad = value;
            }
        }

        // Cantidad de hijos promedio por especie.
        Dictionary<string, decimal> cantidad_hijos_promedio_especie = new Dictionary<string, decimal>()
        {
            { "Gofue", 0 },
            { "Taplan", 0 },
            { "Doti", 0 },
            { "Ent", 0 },
            { "Dorvalo", 0 },
            { "Wetar", 0 }
        };
        public Dictionary<string, decimal> CantidadHijosPromedioEspecie
        {
            get
            {
                return cantidad_hijos_promedio_especie;
            }
            set
            {
                cantidad_hijos_promedio_especie = value;
            }
        }

        // Lista de especies extintas, si las hay.
        List<string> especies_extintas = new List<string>() { "No hay especies extintas" };
        public List<string> EspeciesExtintas
        {
            get
            {
                return especies_extintas;
            }
            set
            {
                especies_extintas = value;
            }
        }

        // Listado de bitmons en el bithala, cantidad por especie, mostrar en porcentaje.
        Dictionary<string, int> bithala_cantidad_bitmons_especie = new Dictionary<string, int>()
        {
            { "Gofue", 0 },
            { "Taplan", 0 },
            { "Doti", 0 },
            { "Ent", 0 },
            { "Dorvalo", 0 },
            { "Wetar", 0 }
        };
        public Dictionary<string, int> BithalaCantidadBitmonsEspecie
        {
            get
            {
                return bithala_cantidad_bitmons_especie;
            }
            set
            {
                bithala_cantidad_bitmons_especie = value;
            }
        }




        public Estadisticas()
        {
            InitializeComponent();
            // Aquí hay que settear las variables de arriba a los controles del form
            
            
        }

        public void LoadData()
        {
            // 1
            label_tiempo_vida_promedio.Text = $"{tiempo_vida_promedio}";

            // 2
            listBox_tiempo_vida_promedio_especies.DataSource = new List<string>()
            {
                $"Gofue {tiempo_vida_promedio_especie["Gofue"]}",
                $"Taplan {tiempo_vida_promedio_especie["Taplan"]}",
                $"Doti {tiempo_vida_promedio_especie["Doti"]}",
                $"Ent {tiempo_vida_promedio_especie["Ent"]}",
                $"Dorvalo {tiempo_vida_promedio_especie["Dorvalo"]}",
                $"Wetar {tiempo_vida_promedio_especie["Wetar"]}"
            };

            // 3
            listBox_tasa_bruta_natalidad_especie.DataSource = new List<string>()
            {
                $"Gofue {tasa_bruta_natalidad_especie["Gofue"]}",
                $"Taplan {tasa_bruta_natalidad_especie["Taplan"]}",
                $"Doti {tasa_bruta_natalidad_especie["Doti"]}",
                $"Ent {tasa_bruta_natalidad_especie["Ent"]}",
                $"Dorvalo {tasa_bruta_natalidad_especie["Dorvalo"]}",
                $"Wetar {tasa_bruta_natalidad_especie["Wetar"]}"
            };

            // 4
            label_tasa_bruta_mortalidad.Text = $"{tasa_bruta_mortalidad}";

            // 5
            listBox_cantidad_hijos_promedio_especie.DataSource = new List<string>()
            {
                $"Gofue {cantidad_hijos_promedio_especie["Gofue"]}",
                $"Taplan {cantidad_hijos_promedio_especie["Taplan"]}",
                $"Doti {cantidad_hijos_promedio_especie["Doti"]}",
                $"Ent {cantidad_hijos_promedio_especie["Ent"]}",
                $"Dorvalo {cantidad_hijos_promedio_especie["Dorvalo"]}",
                $"Wetar {cantidad_hijos_promedio_especie["Wetar"]}"
            };

            // 6
            listBox_especies_extintas.DataSource = especies_extintas;

            // 7
            listBox_bithala_especies.DataSource = new List<string>()
            {
                $"Gofue {bithala_cantidad_bitmons_especie["Gofue"]}",
                $"Taplan {bithala_cantidad_bitmons_especie["Taplan"]}",
                $"Doti {bithala_cantidad_bitmons_especie["Doti"]}",
                $"Ent {bithala_cantidad_bitmons_especie["Ent"]}",
                $"Dorvalo {bithala_cantidad_bitmons_especie["Dorvalo"]}",
                $"Wetar {bithala_cantidad_bitmons_especie["Wetar"]}"
            };
        }
    }
}
