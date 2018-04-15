using System;
using System.IO;
using System.Collections.Generic;

namespace ProyectoVVSS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Correo: ");
            string correo = Console.ReadLine();
            Console.Write("Contraseña: ");
            string clave = Console.ReadLine();

            /*aqui va un validador de usuario ingresado
             * 0.Validar mail miUandes
             * 1.Validar existencia de usuario, si no existe que se registre
             * 2.Validar contraseña con mail ingresado
             * 3.Ver tipo de usuario (admin, user, etc..)
             */
            Menu:
            Console.WriteLine("Bienvenido" + /*nombre usuario*/ "!\n" +
                "1.Ingresar Presupuesto\n" +
                "2.Ver Locales disponibles\n" +
                "3.Cerrar Sesion\n");
            Console.Write("Opcion: ");
            string opcion = Console.ReadLine();
            if (opcion=="1")
            {
                Console.WriteLine("\n---------------------------");
                Console.WriteLine("Proximamente...");
                Console.WriteLine("---------------------------\n");
                goto Menu;
            }
            else if (opcion=="2")
            {
                Console.WriteLine("\n---------------------------");
                Console.WriteLine("Proximamente...");
                Console.WriteLine("---------------------------\n");
                goto Menu;
            }
            else if (opcion == "3")
            {
                goto Fin;
            }




            Fin:
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
