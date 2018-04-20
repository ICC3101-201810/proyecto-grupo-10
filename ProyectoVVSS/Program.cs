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
            List<Users> usuarios = Metodos.GetUsuarios(@"usuarios.txt");
            List<Users> admins_app = Metodos.GetAdmin(@"admin_app.txt");
            /*Archivos txt donde se almacena informacion con usuarios, admins, locales, etc... 
            StreamWriter registro_usuarios = new StreamWriter(Metodos.GetDirectrio(@"usuarios.txt"));
            StreamWriter registro_admin_app = new StreamWriter(Metodos.GetDirectrio(@"admin_app.txt"));
            StreamWriter registro_admin_local = new StreamWriter(Metodos.GetDirectrio(@"admin_local.txt"));*/
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
            List<DateTime> registroLog = new List<DateTime>();
            Users login = Metodos.Log_In(usuarios, correo, clave);
            string tipo = Metodos.DiferenciaUser(login);
            DateTime inicio = DateTime.Now;
            registroLog.Add(inicio);
            DateTime Cierra;
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
            if (tipo=="App")
            {
                goto Menu_Admin_App;
            }
            else if (tipo=="Local")
            {
                goto Menu_Admin_Local;
            }
            else
            {
                goto Menu_User;
            }
            Menu_User:
            Metodos.MenuUser(login);
            string opcion = Console.ReadLine();
            if (opcion=="6")
            {
                Cierra = DateTime.Now;
                registroLog.Add(Cierra);
                Metodos.Logging(registroLog, registro_log, login);
                goto Inicio;
            }
            Menu_Admin_Local:
            Metodos.MenuAdmin_Local();
            string opc = Console.ReadLine();
            if (opc == "5")
            {
                Cierra = DateTime.Now;
                registroLog.Add(Cierra);
                Metodos.Logging(registroLog, registro_log, login);
                goto Inicio;
            }

            Menu_Admin_App:
            Metodos.MenuAdmin_App();
            string opci = Console.ReadLine();
            if (opci == "6")
            {
                Cierra = DateTime.Now;
                registroLog.Add(Cierra);
                Metodos.Logging(registroLog, registro_log, login);
                goto Inicio;
            }

            Fin:
            /*registro_admin_app.Close();
            registro_admin_local.Close();
            registro_usuarios.Close();*/
            registro_log.Close();
            Console.WriteLine("Press any key to Exit...");
            Console.ReadKey();
        }
    }
}
