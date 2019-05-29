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
    public partial class Settings : Form
    {
        public int columnas = 7;
        public int filas = 7;
        public int meses = 12;
        public int velocidad = 2000; // duración de cada tick del reloj en milisegundos
        public int bitmons = 10;
        public decimal agua = 0.2m;
        public decimal pasto = 0.2m;
        public decimal nieve = 0.2m;
        public decimal volcan = 0.2m;
        public decimal arena = 0.2m;

        private bool pro_settings = false;
        
        public Settings()
        {
            InitializeComponent();

            columnas_nUpDown.Value = columnas;
            fila_nUpDown.Value = filas;

            numericUpDown_agua.Value = agua;
            numericUpDown_arena.Value = arena;
            numericUpDown_nieve.Value = nieve;
            numericUpDown_pasto.Value = pasto;
            numericUpDown_volcan.Value = volcan;

            numericUpDown_meses.Value = meses;
            numericUpDown_velocidad.Value = velocidad;

            numericUpDown_bitmons.Value = bitmons;
        }

        #region Botones
        private void button_iniciar_Click(object sender, EventArgs e)
        {
            
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            columnas = (int) columnas_nUpDown.Value;
            columnas_nUpDown.Font = new Font(columnas_nUpDown.Font, FontStyle.Regular);
            filas = (int) fila_nUpDown.Value;
            fila_nUpDown.Font = new Font(fila_nUpDown.Font, FontStyle.Regular);

            decimal suma = numericUpDown_agua.Value + numericUpDown_arena.Value + numericUpDown_nieve.Value + numericUpDown_pasto.Value + numericUpDown_volcan.Value;
            if (suma != 0)
            {
                agua = numericUpDown_agua.Value / suma;
                arena = numericUpDown_arena.Value / suma;
                nieve = numericUpDown_nieve.Value / suma;
                pasto = numericUpDown_pasto.Value / suma;
                volcan = numericUpDown_volcan.Value / suma;
            }
            else
            {
                MessageBox.Show("Ingrese al menos un valor distinto a cero en las probabilidades de los terrenos");
            }

            meses = (int) numericUpDown_meses.Value;
            numericUpDown_meses.Font = new Font(numericUpDown_meses.Font, FontStyle.Regular);
            velocidad = (int) numericUpDown_velocidad.Value;
            numericUpDown_velocidad.Font = new Font(numericUpDown_velocidad.Font, FontStyle.Regular);

            if (numericUpDown_bitmons.Value < columnas * filas)
                bitmons = (int)numericUpDown_bitmons.Value;
            else
            {
                MessageBox.Show("La cantidad de bitmons no cabe en el mapa");
                numericUpDown_bitmons.Value = columnas * filas - 1;
            }
            numericUpDown_bitmons.Font = new Font(numericUpDown_bitmons.Font, FontStyle.Regular);

            numericUpDown_agua.Value = agua;
            numericUpDown_agua.Font = new Font(numericUpDown_agua.Font, FontStyle.Regular);
            numericUpDown_arena.Value = arena;
            numericUpDown_arena.Font = new Font(numericUpDown_arena.Font, FontStyle.Regular);
            numericUpDown_nieve.Value = nieve;
            numericUpDown_nieve.Font = new Font(numericUpDown_nieve.Font, FontStyle.Regular);
            numericUpDown_pasto.Value = pasto;
            numericUpDown_pasto.Font = new Font(numericUpDown_pasto.Font, FontStyle.Regular);
            numericUpDown_volcan.Value = volcan;
            numericUpDown_volcan.Font = new Font(numericUpDown_volcan.Font, FontStyle.Regular);

            button_iniciar.Visible = true;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            columnas_nUpDown.Value = 7;
            columnas_nUpDown.Font = new Font(columnas_nUpDown.Font, FontStyle.Regular);
            fila_nUpDown.Value = 7;
            fila_nUpDown.Font = new Font(fila_nUpDown.Font, FontStyle.Regular);

            numericUpDown_agua.Value = 0.2m;
            numericUpDown_agua.Font = new Font(numericUpDown_agua.Font, FontStyle.Regular);
            numericUpDown_arena.Value = 0.2m;
            numericUpDown_arena.Font = new Font(numericUpDown_arena.Font, FontStyle.Regular);
            numericUpDown_nieve.Value = 0.2m;
            numericUpDown_nieve.Font = new Font(numericUpDown_nieve.Font, FontStyle.Regular);
            numericUpDown_pasto.Value = 0.2m;
            numericUpDown_pasto.Font = new Font(numericUpDown_pasto.Font, FontStyle.Regular);
            numericUpDown_volcan.Value = 0.2m;
            numericUpDown_volcan.Font = new Font(numericUpDown_volcan.Font, FontStyle.Regular);

            numericUpDown_meses.Value = 12;
            numericUpDown_meses.Font = new Font(numericUpDown_meses.Font, FontStyle.Regular);
            numericUpDown_velocidad.Value = 2000;
            numericUpDown_velocidad.Font = new Font(numericUpDown_velocidad.Font, FontStyle.Regular);

            numericUpDown_bitmons.Value = bitmons;
            numericUpDown_bitmons.Font = new Font(numericUpDown_bitmons.Font, FontStyle.Regular);
            button_iniciar.Visible = true;
        }
        #endregion

        #region Numeric up downs
        private void columnas_nUpDown_ValueChanged(object sender, EventArgs e)
        {
            columnas_nUpDown.Font = new Font(columnas_nUpDown.Font, FontStyle.Bold);
            button_iniciar.Visible = false;
        }

        private void fila_nUpDown_ValueChanged(object sender, EventArgs e)
        {
            fila_nUpDown.Font = new Font(fila_nUpDown.Font, FontStyle.Bold);
            button_iniciar.Visible = false;
        }

        private void numericUpDown_agua_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_agua.Font = new Font(numericUpDown_agua.Font, FontStyle.Bold);
            button_iniciar.Visible = false;
            progressBar_agua.Value = (int)(numericUpDown_agua.Value * 100);
        }

        private void numericUpDown_pasto_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_pasto.Font = new Font(numericUpDown_pasto.Font, FontStyle.Bold);
            button_iniciar.Visible = false;
            progressBar_pasto.Value = (int)(numericUpDown_pasto.Value * 100);
        }

        private void numericUpDown_nieve_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_nieve.Font = new Font(numericUpDown_nieve.Font, FontStyle.Bold);
            button_iniciar.Visible = false;
            progressBar_nieve.Value = (int)(numericUpDown_nieve.Value * 100);
        }

        private void numericUpDown_volcan_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_volcan.Font = new Font(numericUpDown_volcan.Font, FontStyle.Bold);
            button_iniciar.Visible = false;
            progressBar_volcan.Value = (int)(numericUpDown_volcan.Value * 100);
        }

        private void numericUpDown_arena_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_arena.Font = new Font(numericUpDown_arena.Font, FontStyle.Bold);
            button_iniciar.Visible = false;
            progressBar_arena.Value = (int)(numericUpDown_arena.Value * 100);
        }

        private void numericUpDown_bitmons_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_bitmons.Font = new Font(numericUpDown_bitmons.Font, FontStyle.Bold);
            button_iniciar.Visible = false;
        }

        private void numericUpDown_meses_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_meses.Font = new Font(numericUpDown_meses.Font, FontStyle.Bold);
            button_iniciar.Visible = false;
        }

        private void numericUpDown_velocidad_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_velocidad.Font = new Font(numericUpDown_velocidad.Font, FontStyle.Bold);
            button_iniciar.Visible = false;
        }
        #endregion

        private void button_pro_options_Click(object sender, EventArgs e)
        {
            if (pro_settings == false)
            {
                button_pro_options.Text = "Ver menos opciones";
                pro_settings = true;

                numericUpDown_agua.Visible = true;
                numericUpDown_arena.Visible = true;
                numericUpDown_nieve.Visible = true;
                numericUpDown_pasto.Visible = true;
                numericUpDown_velocidad.Visible = true;
                numericUpDown_volcan.Visible = true;

                label_agua.Visible = true;
                label_arena.Visible = true;
                label_nieve.Visible = true;
                label_pasto.Visible = true;
                label_velocidad.Visible = true;
                label_volcan.Visible = true;

                progressBar_agua.Visible = true;
                progressBar_arena.Visible = true;
                progressBar_nieve.Visible = true;
                progressBar_pasto.Visible = true;
                progressBar_volcan.Visible = true;
            }
            else
            {
                button_pro_options.Text = "Ver más opciones";
                pro_settings = false;

                numericUpDown_agua.Visible = false;
                numericUpDown_arena.Visible = false;
                numericUpDown_nieve.Visible = false;
                numericUpDown_pasto.Visible = false;
                numericUpDown_velocidad.Visible = false;
                numericUpDown_volcan.Visible = false;

                label_agua.Visible = false;
                label_arena.Visible = false;
                label_nieve.Visible = false;
                label_pasto.Visible = false;
                label_velocidad.Visible = false;
                label_volcan.Visible = false;

                progressBar_agua.Visible = false;
                progressBar_arena.Visible = false;
                progressBar_nieve.Visible = false;
                progressBar_pasto.Visible = false;
                progressBar_volcan.Visible = false;
            }
        }
    }
}
