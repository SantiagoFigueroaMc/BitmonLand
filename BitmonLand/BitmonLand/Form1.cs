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
        {
            int rows = 10;
            int cols = 10;

            int pasto_prob = 40;
            int volcan_prob = 1;
            int agua_prob = 10;
            int arena_prob = 20;
            int nieve_prob = 8;


            Random random = new Random();

            InitializeComponent();

            MapLayout.ColumnCount = cols;
            MapLayout.RowCount = rows;
            
            
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Casilla cas = new Casilla();
                    int dice = random.Next(volcan_prob + nieve_prob + agua_prob + pasto_prob + arena_prob);
                    if (dice < volcan_prob)
                        cas.Image = BitmonLand.Properties.Resources.Volcan1;
                    else if (dice < volcan_prob + agua_prob)
                        cas.Image = BitmonLand.Properties.Resources.Agua1;
                    else if (dice < volcan_prob + agua_prob + arena_prob)
                        cas.Image = BitmonLand.Properties.Resources.Arena1;
                    else if (dice < volcan_prob + arena_prob + agua_prob + nieve_prob)
                        cas.Image = BitmonLand.Properties.Resources.Nieve1;
                    else
                        cas.Image = BitmonLand.Properties.Resources.Pasto1;
                    cas.Dock = DockStyle.Fill;
                    cas.SizeMode = PictureBoxSizeMode.StretchImage;
                    MapLayout.Controls.Add(cas, c, r);
                }
            }
            
        }
    }
}
