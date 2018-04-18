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
            List<Users> usuarios = Metodos.GetUsuarios("users.txt");
            List<Users> admins = Metodos.GetAdmin("admins.txt");
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
            Console.Clear();
            Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
            Console.WriteLine("Bienvenido " + login.GetName() + "!\n" +
                "1.Ingresar Presupuesto y ver opciones\n" +
                "2.Ver Locales disponibles\n" +
                "3.Asignar nota o comentario a local\n" +
                "4.Cerrar Sesion\n");
            Console.Write("Opcion: ");
            string opcion = Console.ReadLine();
            if (opcion=="1")
            {
                Console.Clear();
                Console.WriteLine("Proximamente...");
                goto Menu_User;
            }
            else if (opcion=="2")
            {
                Console.Clear();
                Console.WriteLine("Proximamente...");
                goto Menu_User;
            }
            else if (opcion=="3")
            {
                Console.Clear();
                Console.WriteLine("Proximamente...");
                goto Menu_User;
            }
            else if (opcion == "4")
            {
                Console.Clear();
                goto Inicio;
            }




            Fin:
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
