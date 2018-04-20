using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoVVSS
{
    class AdminApp:Users
    {
        public AdminApp(string Mail, string miPass, string miNombre, string miApellido, string miRut, int miSaldo) : base(miNombre, miApellido, miRut, miPass, Mail, miSaldo)
        {
            
        }
        public void AddLocal(List<Local> locales, Local seAgrega)
        {
            locales.Add(seAgrega);
        }
        public void QuitarLocal(List<Local> locales, Local seQuita)
        {
            locales.Remove(seQuita);
        }
        public void AddAdmin()
        {

        }
        public void QuitarAdmin()
        {

        }

    }
}
