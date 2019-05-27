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
    public partial class MainForm : Form
    {
        public MainForm()
        /* Este form equivale a la clase que se hace cargo de 
            * armar el tablero, ubicar y mover a los bitmons.
            */
        {
            // Tableros de más de 400 casillas empiezan a tener problemas al renderizarse.
            // El máximo recomendado es 20 para ambos parametros.
            int rows = 10;
            int cols = 10;

            // Se define la probabilidad de cada tipo de terreno.
            // El 100% sería la suma de estos valores, puede ser 80 o 130 por ejemplo.
            int pasto_prob = 40;
            int volcan_prob = 1;
            int agua_prob = 10;
            int arena_prob = 20;
            int nieve_prob = 8;
            // Tipos de terrenos
            string[] posibles_tipos = { "nieve", "agua", "pasto", "volcan", "arena" };

            // Se define la cantidad de bitmons iniciales
            int bitmons_alive_count = 30;
            // Tipos de bitmons
            string[] bitmonTypes = { "Gofue", "Wetar", "Taplan", "Dorvalo", "Ent" };

            Random random = new Random();

            InitializeComponent();

            MapLayout.ColumnCount = cols;
            MapLayout.RowCount = rows;
            
            // A continuación se arma el tablero
            // Primero se colocan los tipos de terreno
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Casilla cas = new Casilla();
                    int dice = random.Next(volcan_prob + nieve_prob + agua_prob + pasto_prob + arena_prob);
                    if (dice < volcan_prob)
                        cas.BackgroundImage = BitmonLand.Properties.Resources.Volcan1;
                    else if (dice < volcan_prob + agua_prob)
                        cas.BackgroundImage = BitmonLand.Properties.Resources.Agua1;
                    else if (dice < volcan_prob + agua_prob + arena_prob)
                        cas.BackgroundImage = BitmonLand.Properties.Resources.Arena1;
                    else if (dice < volcan_prob + arena_prob + agua_prob + nieve_prob)
                        cas.BackgroundImage = BitmonLand.Properties.Resources.Nieve1;
                    else
                        cas.BackgroundImage = BitmonLand.Properties.Resources.Pasto1;
                    cas.Dock = DockStyle.Fill;
                    MapLayout.Controls.Add(cas, c, r);
                }
            }
            // Luego se colocan los bitmons iniciales
            List<Bitmon> bitmons_alive = new List<Bitmon>();
            int contador = 0;
            foreach(Casilla c in MapLayout.Controls)
            {
                if(random.Next(100) < 30) // Probabilidad de que aparezca un bitmon
                {
                    if (bitmons_alive_count > 0)
                    {
                        bitmons_alive_count--;
                        Bitmon b = new Bitmon();
                        b.Tipo = bitmonTypes.ElementAt(random.Next(bitmonTypes.Count()));
                        b.Posicion = contador;
                        c.AddOcupante(b);
                    }
                    if (random.Next(100) < 20) // Probabilidad de que aparezca un segundo bitmon
                    {
                        if (bitmons_alive_count > 0)
                        {
                            bitmons_alive_count--;
                            Bitmon b = new Bitmon();
                            b.Tipo = bitmonTypes.ElementAt(random.Next(bitmonTypes.Count()));
                            b.Posicion = contador;
                            c.AddOcupante(b);
                        }
                    }
                }
                contador++;
            }
        }

        private void timer_mes_Tick(object sender, EventArgs e)
        {
            // recorrer bitmons_alive para mover a los wns
            // 

            // recorrer casillas del mapa para que interactuen los wns

            // Hay que revisar el tipo de interaccion
        }

        private void Interactuar(Bitmon bitmon1, Bitmon bitmon2)
        {

        }

        private void Amor(Bitmon bitmon1, Bitmon bitmon2)
        {
            // crear nuevo bitmon siguiendo las reglas
            // agregar bitmon al mapa si es posible
            // puede ser con un foreach, un contador y un limite aleatorio
        }

        private void Odio(Bitmon bitmon1, Bitmon bitmon2)
        {
            // pelear, y eliminar al bitmon perdedor de la casilla
        }
    }
}
