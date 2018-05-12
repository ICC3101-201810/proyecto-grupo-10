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
        }
        public void QuitarLocal(List<Local> locales, string nombre)
        {
            Local aQuitar = Metodos.BuscaLocal(nombre, locales);
            locales.Remove(aQuitar);
        }
        public void AddAdmin(List<AdminLocal> admin_local)
        {

        }
        public void QuitarAdmin()
        {

        }

        public void QuitarUser(List<Users> usuarios, string mail)
        {
            Users aQuitar = Metodos.BuscaUsuario(usuarios, mail);
            usuarios.Remove(aQuitar);
        }
    }
}
