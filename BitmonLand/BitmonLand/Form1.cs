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
        List<Bitmon> bitmons_alive = new List<Bitmon>();
        List<Bitmon> bithalla = new List<Bitmon>();
        int rows;
        int cols;
        int mes_actual = 0;
        int meses_restantes = 0;
        Random random = new Random();
        Estadisticas estadisticas = new Estadisticas(); // Guardar en los atributos de estadisticas lo que haga falta

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
            label_bitmons_vivos.Text = $"Bitmons vivos: {bitmons_initial_count}";
            label_bitmons_muertos.Text = $"Bitmons muertos: {bithalla.Count}";

            // Tipos de bitmons
            string[] bitmonTypes = { "Gofue", "Wetar", "Taplan", "Dorvalo", "Ent", "Doti" }; // santiago, falta Doti


            timer_mes.Interval = (int)(settings.velocidad); // duracion en milisegundos de cada mes
            meses_restantes = settings.meses; // cantidad de meses a simular
            label_meses_restantes.Text = $"Meses restantes: {meses_restantes}";
            label_mes_actual.Text = "Mes actual: 0";


            MapLayout.Controls.Clear();
            MapLayout.ColumnCount = cols;
            MapLayout.RowCount = rows;
            MapLayout.Dock = DockStyle.None;
            MapLayout.Padding = new Padding(1,1,1,1);
            
            
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
                    cas.Margin = new Padding(0,0,0,0);
                    cas.Dock = DockStyle.Fill;
                    
                    MapLayout.Controls.Add(cas, c, r);
                }
            }

            //definir posiciones de los bitmons iniciales, sin repetir posicion inicial
            List<int> posiciones_iniciales = new List<int>();
            for (int j = 0; j < bitmons_initial_count; j++)
            {
                int r_p = random.Next(cols * rows);
                while (posiciones_iniciales.Contains(r_p))
                {
                    r_p = random.Next(cols * rows);
                }
                posiciones_iniciales.Add(r_p);
            }

            // Luego se colocan los bitmons iniciales
            int contador = 0;
            foreach(Casilla c in MapLayout.Controls)
            {
                if (posiciones_iniciales.Contains(contador))
                {
                    string t = bitmonTypes.ElementAt(random.Next(bitmonTypes.Count()));
                    Bitmon b = new Bitmon();
                    if (t == "Gofue")
                    {
                        b = new Gofue();
                    }
                    else if (t == "Wetar")
                    {
                        b = new Wetar();
                    }
                    else if (t == "Taplan")
                    {
                        b = new Taplan();
                    }
                    else if (t == "Dorvalo")
                    {
                        b = new Dorvalo();
                    }
                    else if (t == "Ent")
                    {
                        b = new Ent();
                    }
                    else if (t == "Doti")
                    {
                        b = new Doti();
                    }
                    b.Tipo = t; // se define un tipo aleatorio
                    b.Posicion = contador;
                    b.SizeMode = PictureBoxSizeMode.Zoom;
                    b.Size = new Size((int)(600 / cols / 3), (int)(600 / cols / 3));
                    c.AddOcupante(b);
                    bitmons_alive.Add(b);
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
                label_bitmons_vivos.Text = $"Bitmons vivos: {bitmons_alive.Count}";
                label_bitmons_muertos.Text = $"Bitmons muertos: {bithalla.Count}";

                // recorrer bitmons_alive para mover a los wns. 
                // Si los bitmons no se mueven, puede ser porque se quedan en una casilla nueva, en vez de la de maplayout.
                foreach (Bitmon bitmon in bitmons_alive)
                {
                    if (bitmon.Tipo != "Ent")
                    {
                        int antigua_posicion = bitmon.Posicion;
                        Casilla antigua_casilla = (Casilla)MapLayout.Controls[antigua_posicion];
                        int nueva_posicion = bitmon.Moverse(cols, rows);
                        Casilla nueva_casilla = (Casilla)MapLayout.Controls[nueva_posicion];
                        if (nueva_casilla.ContarOcupantes < 2)
                        {
                            nueva_casilla.AddOcupante(bitmon);
                            antigua_casilla.Ocupantes.Remove(bitmon);
                            bitmon.Posicion = nueva_posicion;
                        }
                        else
                        {
                            bitmon.Posicion = antigua_posicion;
                        }
                    }
                }

                // recorrer casillas del mapa para que interactuen los wns
                foreach(Casilla casilla in MapLayout.Controls)
                {
                    if (casilla.ContarOcupantes == 2)
                    {
                        Interactuar(casilla,casilla.Ocupantes[0], casilla.Ocupantes[1]);
                    }
                    foreach(Bitmon bitmon in casilla.Ocupantes)
                    {
                        casilla.Tipo = bitmon.InteractuarTerreno(casilla.Tipo);
                    }
                }

                // Hay que revisar el tipo de interaccion
                // revisada
                // hola, voy a agregar todo lo necesario para que los bitmons no tengan juventud eterna
                foreach (Casilla casilla in MapLayout.Controls)
                {
                    for(int i=casilla.Ocupantes.Count-1; i>=0; --i) 
                    {
                        try
                        {
                            Bitmon bitmon = casilla.Ocupantes[i];
                            bitmon.envejecer();
                            if (bitmon.getedad() >= bitmon.getTvida())
                            {
                                casilla.BorrarOcupante(bitmon);
                                bitmons_alive.Remove(bitmon);
                                bithalla.Add(bitmon);
                            }

                        }
                        catch (Exception)
                        {

                        }
                    }

                }
                mes_actual++;
            }
            else
            {
                timer_mes.Stop();
                button_ver_estadisticas.Visible = true;
            }
        }

        private void Interactuar(Casilla c,Bitmon bitmon1, Bitmon bitmon2)
        {
            if ((bitmon1.Tipo=="Gofue" && bitmon2.Tipo=="Taplan")||(bitmon1.Tipo == "Taplan" && bitmon2.Tipo == "Gofue"))
            {
                this.Odio(c,bitmon1, bitmon2);
            }
            else if((bitmon1.Tipo == "Wetar" && bitmon2.Tipo == "Dorvalo")|| (bitmon1.Tipo == "Wetar" && bitmon2.Tipo == "Dorvalo"))
            {
                this.Odio(c,bitmon1, bitmon2);
            }
            else if((bitmon1.Tipo=="Dorvalo" && bitmon2.Tipo=="Taplan")|| (bitmon1.Tipo == "Taplan" && bitmon2.Tipo == "Dorvalo"))
            {
                this.Odio(c, bitmon1, bitmon2);
            }
            else if ((bitmon1.Tipo == "Dorvalo" && bitmon2.Tipo == "Gofue") || (bitmon1.Tipo == "Dorvalo" && bitmon2.Tipo == "Dorvalo"))
            {
                this.Odio(c, bitmon1, bitmon2);
            }
            else
            {
                this.Amor(c,bitmon1, bitmon2);
            }

        
        }

        private void Amor(Casilla c,Bitmon bitmon1, Bitmon bitmon2)
        {
            // crear nuevo bitmon siguiendo las reglas
            string tipo;
            double prob1;
            Bitmon bitmon;
            //con que probabilidad tendra la raza del progenitor 1 o 2
            if (bitmon1.Tipo != "Ent" && bitmon2.Tipo != "Ent")
            {
                if (bitmon1.getCantHijos() > bitmon2.getCantHijos())
                {
                    prob1 = 0.7;
                }
                else if (bitmon1.getCantHijos() < bitmon2.getCantHijos())
                {
                    prob1 = 0.3;
                }
                else
                {
                    prob1 = 0.5;
                }
                bitmon1.tenerHijo();
                bitmon2.tenerHijo(); 
                // de quien hereda la raza
                if (random.NextDouble() < prob1)
                {
                    tipo = bitmon1.Tipo;
                }
                else
                {
                    tipo = bitmon2.Tipo;
                }

                if (tipo == "Gofue")
                {
                    bitmon = new Gofue();
                }
                else if (tipo == "Dorvalo")
                {
                    bitmon = new Dorvalo();
                }
                else if (tipo == "Taplan")
                {
                    bitmon = new Taplan();
                }
                else if (tipo == "Ent")
                {
                    bitmon = new Ent();
                }
                else if (tipo == "Wetar")
                {
                    bitmon = new Wetar();
                }
                else
                {
                    bitmon = new Doti();
                }

                if (bitmon1.Tipo == bitmon2.Tipo)//los purasangre son mas fuertes
                {
                    bitmon.boostataque(5); bitmon.boostvida(18);
                }
                // agregar bitmon al mapelse if (tipo == "Gofue")a si es posible
                // todo lo que al nacer aparece en un terreno ocupado (2 bitmons) muere al instante (el fuerte se aprovecha del debil!)
                bool pocisionado = false;
                int potencialCasilla = random.Next((cols * rows));
                int cont = 0;
                foreach (Casilla casilla in MapLayout.Controls)
                {
                    if (cont == potencialCasilla)
                    {
                        pocisionado = casilla.AddOcupante(bitmon);
                        if (pocisionado)
                        {
                            bitmon.SizeMode = PictureBoxSizeMode.Zoom;
                            bitmon.Size = new Size((int)(600 / cols / 3), (int)(600 / cols / 3));

                            bitmons_alive.Add(bitmon);
                            bitmon.setpocision(cont);
                        }
                        else bithalla.Add(bitmon);
                        break;
                    }

                    ++cont;
                }
            }
        }

        private void Odio(Casilla c,Bitmon bitmon1, Bitmon bitmon2)
        {
            int vida1 = bitmon1.getvida();
            int vida2 = bitmon2.getvida();
            int ataque1 = bitmon1.getataque();
            int ataque2 = bitmon2.getataque();

            while(vida1>=1 && vida2>=1)
            {
                vida1 -= ataque2;
                vida2 -= ataque1;
            }

            if (vida1 < 1)
            {
                bitmons_alive.Remove(bitmon1);
                bithalla.Add(bitmon1);
                c.BorrarOcupante(bitmon1);


            }
            if (vida2 < 1)
            {
                bitmons_alive.Remove(bitmon2);
                bithalla.Add(bitmon2);
                c.BorrarOcupante(bitmon2);
            }

        }

        private void button_ver_estadisticas_Click(object sender, EventArgs e)
        {
            estadisticas.ShowDialog();
        }
    }
}
