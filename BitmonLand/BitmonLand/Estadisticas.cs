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
        int tiempo_vida_promedio;

        // Tiempo de vida promedio de cada especie de Bitmon.
        Dictionary<string, int> tiempo_vida_promedio_especie = new Dictionary<string, int>()
        {
            { "Gofue", 0 },
            { "Taplan", 0 },
            { "Doti", 0 },
            { "Ent", 0 },
            { "Dorvalo", 0 },
            { "Wetar", 0 }
        };

        // Tasa bruta de natalidad de cada especie.
        Dictionary<string, int> tasa_bruta_natalidad_especie = new Dictionary<string, int>()
        {
            { "Gofue", 0 },
            { "Taplan", 0 },
            { "Doti", 0 },
            { "Ent", 0 },
            { "Dorvalo", 0 },
            { "Wetar", 0 }
        };

        // Tasa bruta de mortalidad.
        int tasa_bruta_mortalidad_especie;

        // Cantidad de hijos promedio por especie.
        Dictionary<string, int> cantidad_hijos_promedio_especie = new Dictionary<string, int>()
        {
            { "Gofue", 0 },
            { "Taplan", 0 },
            { "Doti", 0 },
            { "Ent", 0 },
            { "Dorvalo", 0 },
            { "Wetar", 0 }
        };

        // Lista de especies extintas, si las hay.
        List<string> especies_extintas = new List<string>() { "No hay especies extintas" };

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





        public Estadisticas()
        {
            InitializeComponent();
            // Aquí hay que settear las variables de arriba a los controles del form
        }
    }
}
