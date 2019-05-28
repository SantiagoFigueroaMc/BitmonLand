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
        List<Bitmon> bitmons_alive;
        int rows;
        int cols;
        int mes_actual = 0;
        int meses_restantes = 0;
        public MainForm()
        /* Este form equivale a la clase que se hace cargo de 
            * armar el tablero, ubicar y mover a los bitmons.
            */
        {
            InitializeComponent();

            Settings settings = new Settings();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Iniciando simulacion");
            }


            // Tableros de más de 400 casillas empiezan a tener problemas al renderizarse.
            // El máximo recomendado es 20 para ambos parametros.
            rows = settings.filas;
            cols = settings.columnas;

            // Se define la probabilidad de cada tipo de terreno.
            // El 100% sería la suma de estos valores, puede ser 80 o 130 por ejemplo.
            int pasto_prob = (int)(settings.pasto * 100);
            int volcan_prob = (int)(settings.volcan * 100);
            int agua_prob = (int)(settings.agua * 100);
            int arena_prob = (int)(settings.arena * 100);
            int nieve_prob = (int)(settings.nieve * 100);
            // Tipos de terrenos
            string[] posibles_tipos = { "nieve", "agua", "pasto", "volcan", "arena" };

            // Se define la cantidad de bitmons iniciales
            int bitmons_initial_count = settings.bitmons;
            // Tipos de bitmons
            string[] bitmonTypes = { "Gofue", "Wetar", "Taplan", "Dorvalo", "Ent" };


            timer_mes.Interval = settings.velocidad; // duracion en milisegundos de cada mes
            meses_restantes = settings.meses; // cantidad de meses a simular
            label_meses_restantes.Text = $"Meses restantes: {meses_restantes}";

            Random random = new Random();



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
            bitmons_alive = new List<Bitmon>();
            List<Bitmon> bithalla = new List<Bitmon>();
            int contador = 0;
            foreach(Casilla c in MapLayout.Controls)
            {
                if(random.Next(100) < 30) // Probabilidad de que aparezca un bitmon
                {
                    if (bitmons_initial_count > 0)
                    {
                        bitmons_initial_count--;
                        Bitmon b = new Bitmon();
                        b.Tipo = bitmonTypes.ElementAt(random.Next(bitmonTypes.Count()));
                        b.Posicion = contador;
                        c.AddOcupante(b);
                    }
                    if (random.Next(100) < 20) // Probabilidad de que aparezca un segundo bitmon
                    {
                        if (bitmons_initial_count > 0)
                        {
                            bitmons_initial_count--;
                            Bitmon b = new Bitmon();
                            b.Tipo = bitmonTypes.ElementAt(random.Next(bitmonTypes.Count()));
                            b.Posicion = contador;
                            c.AddOcupante(b);
                        }
                    }
                }
                contador++;
            }
            timer_mes.Start();
        }

        private void timer_mes_Tick(object sender, EventArgs e)
        {
            if (mes_actual <= meses_restantes)
            {
                label_mes_actual.Text = $"Mes actual: {mes_actual}";
                // recorrer bitmons_alive para mover a los wns. 
                // Si los bitmons no se mueven, puede ser porque se quedan en una casilla nueva, en vez de la de maplayout.
                foreach(Bitmon bitmon in bitmons_alive)
                {
                    int nueva_posicion = bitmon.Moverse(cols, rows);
                    Casilla nueva_casilla = (Casilla)MapLayout.Controls[nueva_posicion];
                    if (nueva_casilla.ContarOcupantes < 2)
                    {
                        nueva_casilla.AddOcupante(bitmon);
                        bitmon.Posicion = nueva_posicion;
                    }
                }

                // recorrer casillas del mapa para que interactuen los wns
                foreach(Casilla casilla in MapLayout.Controls)
                {
                    if (casilla.ContarOcupantes == 2)
                    {
                        if(casilla.Ocupantes[0].Tipo == casilla.Ocupantes[1].Tipo)
                        {
                            Amor(casilla.Ocupantes[0], casilla.Ocupantes[1]);
                        }
                    }
                    foreach(Bitmon bitmon in casilla.Ocupantes)
                    {
                        casilla.Tipo = bitmon.InteractuarTerreno(casilla.Tipo);
                    }
                }

                // Hay que revisar el tipo de interaccion

                mes_actual++;
            }
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
