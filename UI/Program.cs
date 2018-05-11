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
            /*Producto Pan = new Producto("Completo Italiano", 1000, 100, 123);
            Producto Trensa = new Producto("Cruzado Nutella", 980, 150, 124);
            Producto Donut = new Producto("Donut Nutella", 980, 150, 135);
            Producto Ensalada1 = new Producto("Ensalada Cesar", 2500, 35, 324);
            List<Local> locales = Metodos.DeserializarLocal();
            foreach (Local l in locales)
            {
                l.menu.Add(Pan);
                l.menu.Add(Trensa);
                l.menu.Add(Donut);
                l.menu.Add(Ensalada1);
            }
            Metodos.SerializarLocal(locales);*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 inicio = new Form1();
            LogInController controlador = new LogInController(inicio);
            Application.Run(inicio);
        }
    }
}
