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
        public int velocidad = 100; // duración de cada tick del reloj en milisegundos
        public int bitmons = 10;
        public decimal agua = 0.2m;
        public decimal pasto = 0.2m;
        public decimal nieve = 0.2m;
        public decimal volcan = 0.2m;
        public decimal arena = 0.2m;
        
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
            filas = (int) fila_nUpDown.Value;

            decimal suma = numericUpDown_agua.Value + numericUpDown_arena.Value + numericUpDown_nieve.Value + numericUpDown_pasto.Value + numericUpDown_volcan.Value;
            agua = numericUpDown_agua.Value / suma;
            arena = numericUpDown_arena.Value / suma;
            nieve = numericUpDown_nieve.Value / suma;
            pasto = numericUpDown_pasto.Value / suma;
            volcan = numericUpDown_volcan.Value / suma;

            meses = (int) numericUpDown_meses.Value;
            velocidad = (int) numericUpDown_velocidad.Value;

            if (numericUpDown_bitmons.Value < columnas * filas)
                bitmons = (int)numericUpDown_bitmons.Value;
            else
                bitmons = filas * columnas - 1;

            numericUpDown_agua.Value = agua;
            numericUpDown_arena.Value = arena;
            numericUpDown_nieve.Value = nieve;
            numericUpDown_pasto.Value = pasto;
            numericUpDown_volcan.Value = volcan;

            button_iniciar.Visible = true;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            columnas_nUpDown.Value = 7;
            fila_nUpDown.Value = 7;

            numericUpDown_agua.Value = 0.2m;
            numericUpDown_arena.Value = 0.2m;
            numericUpDown_nieve.Value = 0.2m;
            numericUpDown_pasto.Value = 0.2m;
            numericUpDown_volcan.Value = 0.2m;

            numericUpDown_meses.Value = 12;
            numericUpDown_velocidad.Value = 100;

            numericUpDown_bitmons.Value = bitmons;
            button_iniciar.Visible = true;
        }
        #endregion

        #region Numeric up downs
        private void columnas_nUpDown_ValueChanged(object sender, EventArgs e)
        {
            button_iniciar.Visible = false;
        }

        private void fila_nUpDown_ValueChanged(object sender, EventArgs e)
        {
            button_iniciar.Visible = false;
        }

        private void numericUpDown_agua_ValueChanged(object sender, EventArgs e)
        {
            button_iniciar.Visible = false;
        }

        private void numericUpDown_pasto_ValueChanged(object sender, EventArgs e)
        {
            button_iniciar.Visible = false;
        }

        private void numericUpDown_nieve_ValueChanged(object sender, EventArgs e)
        {
            button_iniciar.Visible = false;
        }

        private void numericUpDown_volcan_ValueChanged(object sender, EventArgs e)
        {
            button_iniciar.Visible = false;
        }

        private void numericUpDown_arena_ValueChanged(object sender, EventArgs e)
        {
            button_iniciar.Visible = false;
        }

        private void numericUpDown_bitmons_ValueChanged(object sender, EventArgs e)
        {
            button_iniciar.Visible = false;
        }

        private void numericUpDown_meses_ValueChanged(object sender, EventArgs e)
        {
            button_iniciar.Visible = false;
        }

        private void numericUpDown_velocidad_ValueChanged(object sender, EventArgs e)
        {
            button_iniciar.Visible = false;
        }
        #endregion
    }
}
