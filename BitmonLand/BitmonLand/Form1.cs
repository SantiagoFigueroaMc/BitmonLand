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

            InitializeComponent();

            MapLayout.ColumnCount = cols;
            MapLayout.RowCount = rows;
            
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    MapLayout.Controls.Add(new Casilla(), c, r);
                }
            }
            foreach(Casilla c in MapLayout.Controls)
            {
                c.Image = BitmonLand.Properties.Resources.Agua1;
                c.Dock = DockStyle.Fill;
                c.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
