using System;
using System.Collections.Generic;
using System.Text;


namespace ProyectoVVSS
{
    class Users
    {
        string nombre;
        string apellido;
        string rut;
        string password;
        string mail;

        public Users(string miNombre, string miApellido, string miRut, string miPass, string Mail)
        {
            nombre = miNombre;
            apellido = miApellido;
            rut = miRut;
            password = miPass;
            mail = Mail;
        }

        public virtual string getName()
        {
            return this.nombre;
        }

    }
}
