using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace ProyectoVVSS
{
    class Program
    {
        static void Main(string[] args)
        {
            Users algo = new AdminApp("prueba", "prueba", "12345", "asdqwe", "a@miuandes.cl", 0);
            Console.WriteLine(algo.GetType().ToString());



            List<Users> usuarios = Metodos.GetUsuarios(@"usuarios.txt");
            List<Users> admins_app = Metodos.GetAdmin(@"admin_app.txt");
            /*Archivos txt donde se almacena informacion con usuarios, admins, locales, etc... */
            StreamWriter registro_usuarios = new StreamWriter(Metodos.GetDirectrio(@"usuarios.txt"));
            StreamWriter registro_admin_app = new StreamWriter(Metodos.GetDirectrio(@"admin_app.txt"));
            StreamWriter registro_admin_local = new StreamWriter(Metodos.GetDirectrio(@"admin_local.txt"));
            StreamWriter registro_log = new StreamWriter(Metodos.GetDirectrio(@"log.txt"));
            

            /*Menu de log in generico para los usuarios y los 2 tipos de admin*/
            Inicio:
            Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
            string correo;
            string clave;
            Console.WriteLine("1.Log-in \n2.Registrarse\n3.Salir \n");
            string variable = Console.ReadLine();
            if (variable=="3")
            {
                goto Fin;
            }
            Ingresar:
            Console.WriteLine("Deje este campo vacio para volver");
            Console.Write("Correo: ");
            correo = Console.ReadLine();
            if (correo == "")
            {
                Console.Clear();
                goto Inicio;
            }
            Console.Write("Contraseña: ");
            clave = Console.ReadLine();
                if (Metodos.VerificaMail(correo) && Metodos.Mail(correo))
                {
                goto Loguea;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
                    Console.WriteLine("Correo Invalido...");
                    goto Ingresar;
                }
            /*aqui va un validador de usuario ingresado
             * 0.Validar mail miUandes: 100%
             * 1.Validar existencia de usuario, si no existe que se registre: 100%
             * 2.Validar contraseña con mail ingresado: 100%
             * 3.Ver tipo de usuario (admin, user, etc..) 0%
             */
            Loguea:
            Users login = Metodos.Log_In(usuarios, correo, clave);
            try
            {
                login.GetName();
            }
            catch (System.NullReferenceException)
            {

                Console.Clear();
                Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
                Console.WriteLine("Mail o correo invalido...");
                goto Ingresar;
            }

            Menu_User:
            Metodos.MenuUser(login);

            Menu_Admin_Local:
            Metodos.MenuAdmin_Local();

            Menu_Admin_App:
            Metodos.MenuAdmin_App();

            registro_admin_app.Close();
            registro_admin_local.Close();
            registro_log.Close();
            registro_usuarios.Close();
            Fin:
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
