using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmonLand
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            EstadisticasModel estadisticas_model = new EstadisticasModel();
            Controlador controlador = new Controlador(mainForm, estadisticas_model);
            Application.Run(mainForm);
        }
    }
}
