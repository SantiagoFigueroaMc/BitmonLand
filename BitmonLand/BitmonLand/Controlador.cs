using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmonLand
{
    class Controlador
    {
        MainForm form;
        EstadisticasModel estadisticas_model;
        Random random = new Random();
        // Controlar el programa
        public Controlador(MainForm mf, EstadisticasModel em)
        {
            // añadir las funciones de events y cosas
            form = mf;
            form.OnInteractuar += Interactuar;

            estadisticas_model = em;
        }

        // agregar funciones para que haga la pega cuando ocurran eventos
        private void Interactuar(Casilla c, Bitmon bitmon1, Bitmon bitmon2)
        {
            if ((bitmon1.Tipo == "Gofue" && bitmon2.Tipo == "Taplan") || (bitmon1.Tipo == "Taplan" && bitmon2.Tipo == "Gofue"))
            {
                Odio(c, bitmon1, bitmon2);
            }
            else if ((bitmon1.Tipo == "Wetar" && bitmon2.Tipo == "Dorvalo") || (bitmon1.Tipo == "Wetar" && bitmon2.Tipo == "Dorvalo"))
            {
                Odio(c, bitmon1, bitmon2);
            }
            else if ((bitmon1.Tipo == "Dorvalo" && bitmon2.Tipo == "Taplan") || (bitmon1.Tipo == "Taplan" && bitmon2.Tipo == "Dorvalo"))
            {
                Odio(c, bitmon1, bitmon2);
            }
            else if ((bitmon1.Tipo == "Dorvalo" && bitmon2.Tipo == "Gofue") || (bitmon1.Tipo == "Dorvalo" && bitmon2.Tipo == "Dorvalo"))
            {
                Odio(c, bitmon1, bitmon2);
            }
            else
            {
                Amor(c, bitmon1, bitmon2);
            }


        }
        private void Amor(Casilla c, Bitmon bitmon1, Bitmon bitmon2)
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
                bool TerrenoValido = true;
                int potencialCasilla = random.Next((form.GetCols * form.GetRows));
                int cont = 0;
                foreach (Casilla casilla in form.GetMapLayout.Controls)
                {
                    if (cont == potencialCasilla)
                    {
                        if ((bitmon.Tipo == "Wetar" && casilla.Tipo != "agua"))
                        {
                            TerrenoValido = false;
                        }

                        else pocisionado = casilla.AddOcupante(bitmon);

                        if (pocisionado && TerrenoValido)
                        {
                            bitmon.SizeMode = PictureBoxSizeMode.Zoom;
                            bitmon.Size = new Size((int)(600 / form.GetCols / 3), (int)(600 / form.GetCols / 3));

                            form.GetBitmonsAlive.Add(bitmon);
                            bitmon.setpocision(cont);
                            /* arreglar aqui
                            if (bitmon.Tipo == "Gofue")
                                gofue_nacidos_mes++;
                            if (bitmon.Tipo == "Taplan")
                                taplan_nacidos_mes++;
                            if (bitmon.Tipo == "Dorvalo")
                                dorvalo_nacidos_mes++;
                            if (bitmon.Tipo == "Wetar")
                                wetar_nacidos_mes++;
                            if (bitmon.Tipo == "Dorvalo")
                                dorvalo_nacidos_mes++;
                            */
                        }
                        else form.GetBithalla.Add(bitmon);
                        break;
                    }

                    ++cont;
                }
            }
        }
        private void Odio(Casilla c, Bitmon bitmon1, Bitmon bitmon2)
        {
            int vida1 = bitmon1.getvida();
            int vida2 = bitmon2.getvida();
            int ataque1 = bitmon1.getataque();
            int ataque2 = bitmon2.getataque();

            if (bitmon1.Tipo == "Gofue" && bitmon2.Tipo == "Taplan")
            {
                ataque1 = (int)((double)ataque1 * 1.5); //los gofue tienen ventaja sobre los taplans
            }

            if (bitmon1.Tipo == "Taplan" && bitmon2.Tipo == "Gofue")
            {
                ataque2 = (int)((double)ataque1 * 1.5); //los gofue tienen ventaja sobre los taplans
            }

            if (bitmon1.Tipo == "Dorvalo" && bitmon2.Tipo == "Gofue")
            {
                ataque2 = (int)((double)ataque2 * 0.8);//los dorvalos son resistentes a los gofue
            }

            if (bitmon1.Tipo == "Gofue" && bitmon2.Tipo == "Dorvalo")
            {
                ataque1 = (int)((double)ataque1 * 0.8);//los dorvalos son resistentes a los gofue
            }


            while (vida1 >= 1 && vida2 >= 1)
            {
                vida1 -= ataque2;
                vida2 -= ataque1;
            }

            if (vida1 < 1)
            {
                form.GetBitmonsAlive.Remove(bitmon1);
                form.GetBithalla.Add(bitmon1);
                c.BorrarOcupante(bitmon1);
                // bitmons_muertos_mes++;

            }
            if (vida2 < 1)
            {
                form.GetBitmonsAlive.Remove(bitmon2);
                form.GetBithalla.Add(bitmon2);
                c.BorrarOcupante(bitmon2);
                // bitmons_muertos_mes++;
            }

        }

        /* De aqui para abajo todo está lleno de errores y hay que ir limpiando y re escribiendo de a poco
        private void PlantarUnArbol()
        {
            Bitmon bitmon = new Ent();
            Casilla casilla;
            List<int> posibles_casillas = new List<int>();
            int cont = 0;
            foreach (Casilla c in MapLayout.Controls)
            {
                if (c.Tipo != "volcan" && c.Tipo != "agua" && c.ContarOcupantes < 2)
                {
                    posibles_casillas.Add(cont);
                }
                cont++;
            }
            if (posibles_casillas.Count > 0)
            {
                int casilla_elegida = posibles_casillas.ElementAt(random.Next(posibles_casillas.Count));
                casilla = (Casilla)MapLayout.Controls[casilla_elegida];
                if (casilla.AddOcupante(bitmon))
                {
                    bitmon.SizeMode = PictureBoxSizeMode.Zoom;
                    bitmon.Size = new Size((int)(600 / cols / 3), (int)(600 / cols / 3));

                    bitmons_alive.Add(bitmon);
                    bitmon.setpocision(casilla_elegida);
                    ent_nacidos_mes++;
                }
            }
        }


        private void button_ver_estadisticas_Click(object sender, EventArgs e)
        {
            estadisticas.LoadData();
            estadisticas.ShowDialog();
        }
        */

    }
}
