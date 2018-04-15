using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoVVSS
{
    class Admin : Users
    {
        public Admin(string miNombre, string miApellido, string miRut, string miPass, string Mail) : base(miNombre, miApellido, miRut, miPass, Mail)
        {

        }
    }
}
