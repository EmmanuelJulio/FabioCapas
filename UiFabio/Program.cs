using System;
using System.Windows.Forms;

namespace UiFabio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Configuraciones.Modulos.frm_submenus fr = new Configuraciones.Modulos.frm_submenus();
            Application.Run(new Loggin());
           // Application.Run(fr);
        }
    }
}
