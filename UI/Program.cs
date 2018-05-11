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

            /*List<AdminLocal> admins = new List<AdminLocal>();
            List<Local> locales = Metodos.DeserializarLocal();
            AdminLocal admin1 = new AdminLocal("local@miuandes.cl", "1234", "admin", "Coffee", "1234", 0, locales[1]);
            admins.Add(admin1);
            Metodos.SerializarLocal(locales);
            Metodos.SerializarAdminsLocal(admins);*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 inicio = new Form1();
            LogInController controlador = new LogInController(inicio);
            Application.Run(inicio);
        }
    }
}
