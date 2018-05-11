using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /**********************/
            /*  Icono por Raaes_  */
            /*  Instagram: Raaes_ */
            /**********************/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 inicio = new Form1();
            LogInController controlador = new LogInController(inicio);
            LogInLocalController controlador2 = new LogInLocalController(inicio);
            LogInAppController controlador3 = new LogInAppController(inicio);
            Application.Run(inicio);

        }
    }
}
