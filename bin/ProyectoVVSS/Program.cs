﻿using System;
using System.IO;
using System.Collections.Generic;

namespace ProyectoVVSS
{
    class Program
    {
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
            string correo;
            string clave;
            while (true)
            {
                Console.Write("Correo: ");
                correo = Console.ReadLine();
                Console.Write("Contraseña: ");
                clave = Console.ReadLine();
                if (VerificaMail(correo))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n---------------------------\n Correo Invalido... \n---------------------------\n");
                    continue;
                }
            }
            

            /*aqui va un validador de usuario ingresado
             * 0.Validar mail miUandes: Listo
             * 1.Validar existencia de usuario, si no existe que se registre
             * 2.Validar contraseña con mail ingresado
             * 3.Ver tipo de usuario (admin, user, etc..)
             */

            Menu:
            Console.WriteLine("Bienvenido " + "<nombre usuario> !\n" +
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