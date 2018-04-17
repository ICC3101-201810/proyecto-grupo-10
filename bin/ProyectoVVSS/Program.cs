using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace ProyectoVVSS
{
    class Program
    {
        static bool Mail(string correo) //Comprueba que sea correo valido atraves de una ER
        {
            string pat="[A-Z]*[a-z]*@[a-z]*[A-Z]*.[A-Z]*[a-z]*";
            Regex r = new Regex(pat);
            Match m = r.Match(correo);
            return m.Success;
        }
        static bool VerificaMail(string correo)
        {
            string verifica = "@miuandes.cl";
            int temp = verifica.Length-1;
            for (int i = correo.Length-1; i!=0 ; i--)
            {
                if (temp==0)
                {
                    break;
                }
                else
                {
                    if (correo[i]==verifica[temp])
                    {
                        temp--;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        static void Main(string[] args)
        {
            Login:
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
            Console.Write("Correo: ");
            correo = Console.ReadLine();
            Console.Write("Contraseña: ");
            clave = Console.ReadLine();
                if (VerificaMail(correo) && Mail(correo))
                {
                goto Menu_User;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
                    Console.WriteLine("Correo Invalido...");
                    goto Ingresar;
                }
            /*aqui va un validador de usuario ingresado
             * 0.Validar mail miUandes: Listo
             * 1.Validar existencia de usuario, si no existe que se registre
             * 2.Validar contraseña con mail ingresado
             * 3.Ver tipo de usuario (admin, user, etc..)
             */
            Menu_User:
            Console.Clear();
            Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
            Console.WriteLine("Bienvenido " + "<nombre usuario> !\n" +
                "1.Ingresar Presupuesto y ver opciones\n" +
                "2.Ver Locales disponibles\n" +
                "3.Asignar nota o comentario a local" +
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
                goto Login;
            }




            Fin:
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
