using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    [Serializable]
    public class AdminApp : Users
    {
        public AdminApp(string Mail, string miPass, string miNombre, string miApellido, string miRut, int miSaldo) : base(miNombre, miApellido, miRut, miPass, Mail, miSaldo)
        {

        }
        public void AddLocal(List<Local> locales)
        {
            Console.Write("Nombre del local: ");
            string nombre_local = Console.ReadLine();
            Console.Write("\nRut del Local: ");
            string rut_local = Console.ReadLine();
            Console.Write("\nHora de apertura (hora:min): ");
            string abre = Console.ReadLine();
            string[] hora_a = abre.Split(':');
            DateTime Abre = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(hora_a[0]), Convert.ToInt32(hora_a[1]), 0);
            Console.Write("\nHora de cierre (hora:min): ");
            string cierra = Console.ReadLine();
            string[] hora_c = cierra.Split(':');
            DateTime Cierra = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(hora_c[0]), Convert.ToInt32(hora_c[1]), 0);
            Local seAgrega = new Local(nombre_local, rut_local, Abre, Cierra);
            locales.Add(seAgrega);
        }
        public void QuitarLocal(List<Local> locales)
        {
            Console.Write("Nombre del local: ");
            string nombre = Console.ReadLine();
            Local aQuitar = Metodos.BuscaLocal(nombre, locales);
            locales.Remove(aQuitar);
        }
        public void AddAdmin(List<AdminLocal> admin_local)
        {

        }
        public void QuitarAdmin()
        {

        }


    }
}
