﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace ProyectoVVSS
{
    class Program
    {

        static void Mensaje(string mensaje)
        {
            Console.WriteLine("\n---------------------------\n" + mensaje + "\n---------------------------\n");
        }
        static void Main(string[] args)
        {
            List<Users> usuarios = Metodos.GetUsuarios(@"usuarios.txt");
            List<Users> admins_app = Metodos.GetAdmin(@"admin_app.txt");
            List<Users> admins_local = Metodos.GetAdmin(@"admin_local.txt");
            List<Local> locales = Metodos.GetLocales(@"locales.txt");
            /*Archivos txt donde se almacena informacion con usuarios, admins, locales, etc... */
            StreamWriter registro_usuarios = new StreamWriter(Metodos.GetDirectrio(@"usuarios.txt"));
            StreamWriter registro_admin_app = new StreamWriter(Metodos.GetDirectrio(@"admin_app.txt"));
            StreamWriter registro_admin_local = new StreamWriter(Metodos.GetDirectrio(@"admin_local.txt"));
            StreamWriter registro_log = new StreamWriter(Metodos.GetDirectrio(@"log.txt"));


            /*Menu de log in generico para los usuarios y los 2 tipos de admin*/
            Inicio:
            Mensaje("Proyecto VVSS");
            string correo;
            string clave;
            Console.Write("1.Log-in \n2.Registrarse\n3.Log-in Admin\n4.Salir\nOpcion: ");
            int variable =Convert.ToInt32( Console.ReadLine());
            if (variable>=4)
            {
                goto Fin;
            }
            else if (variable==3)
            {
                Console.Clear();
                goto SoloAdmins;
            }
            else if (variable==2)
            {
                Metodos.Registra(usuarios);
                goto Ingresar;
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
                Console.Clear();
                goto Loguea;
            }
            else
            {
                Console.Clear();
                Mensaje("Proyecto VVSS");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Correo Invalido...");
                Console.ForegroundColor = ConsoleColor.White;
                goto Ingresar;
            }


            Registrar:
            //registro de user
            Metodos.Registra(usuarios);
            goto Ingresar;


            Loguea:
            Users login_1 = Metodos.Log_In(usuarios, correo, clave);
            if (login_1==null)
            {

                Console.Clear();
                Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usuario no encontrado, por favor registrese...");
                Console.ForegroundColor = ConsoleColor.White;
                goto Registrar;
            }


            Menu_User:
            List<DateTime> Log = new List<DateTime>();
            DateTime inicio = DateTime.Now;
            Log.Add(inicio);
            Users login = Metodos.Log_In(usuarios, correo, clave);
            Metodos.MenuUser(login);
            string opcion = Console.ReadLine();
            if (opcion=="1")
            {
                Console.Write("Monto a presupuestar: ");
                int presu = Convert.ToInt32(Console.ReadLine());
                List<Producto> Opciones = login.Presupuestar(locales, presu);
                if (Opciones==null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontraron opciones para el monto: {0}", presu);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (opcion=="2")
            {
                Metodos.ImprimeLocalesAbiertos(locales);
                goto Menu_User;
            }
            else if (opcion=="3")
            {
                Console.Clear();
                Console.WriteLine("Proximamente...");
                goto Menu_User;
            }
            else if (opcion=="4")
            {
                //realizar pedido
                Console.Clear();
                Metodos.ImprimeLocalesAbiertos(locales);
                string elige_local = Console.ReadLine();
                Local selecionado = Metodos.BuscaLocal(elige_local, locales);
                if (selecionado == null) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Local no existe..."); Console.ForegroundColor = ConsoleColor.White; goto Menu_User; }
                selecionado.ImprimeMenu();
                Console.Write("Seleccione el ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Producto comida = Metodos.BuscaProducto(selecionado.GetMenu(), id);
                if (comida == null)
                { 
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Producto no encontrado...");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Menu_User;
                }
                Console.Write("Cuant@s: ");
                int q = Convert.ToInt32(Console.ReadLine());
                bool realiza=login.RealizarPedido(comida, selecionado,q);
                if (realiza==false)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en el pedido...");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Menu_User;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pedido realizado con exito...");
                Console.ForegroundColor = ConsoleColor.White;
                goto Menu_User;

            }
            else if (opcion=="5")
            {
                Console.Write("Monto a abonar: ");
                int abono = Convert.ToInt32(Console.ReadLine());
                login.Abonar(abono);
                Console.Clear();
                Console.WriteLine("Monto Abonado con exito!");
                goto Menu_User;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sesion Cerrada");
                Console.ForegroundColor = ConsoleColor.White;
            }
            DateTime finaliza = DateTime.Now;
            Log.Add(finaliza);
            Metodos.Logging(Log, registro_log, login);
            goto Ingresar;


            /**************************/
            /*      Menu Admins       */
            /**************************/
            SoloAdmins:
            Mensaje("Admins");
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
                Console.Clear();
                goto Loguea_Admin;
            }
            else
            {
                Console.Clear();
                Mensaje("Proyecto VVSS");
                Console.WriteLine("Correo Invalido...");
                goto Ingresar;
            }


            Loguea_Admin:
            List<DateTime> registroLog_a = new List<DateTime>();
            Users login_a = Metodos.Log_In(admins_app, correo, clave);
            Console.WriteLine(login_a.GetType().ToString());
            if (login_a == null)
            {

                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Usuario no existe como admin...");
                Console.ForegroundColor = ConsoleColor.White;
                goto Inicio;
            }
            string tipo = Metodos.DiferenciaAdmin(login_a);
            DateTime inicio_a = DateTime.Now;
            registroLog_a.Add(inicio_a);
            DateTime Cierra_a;
            if (tipo == null) { Console.Clear(); Console.WriteLine("Usuario no es admin..."); goto Ingresar; }
            else if (tipo == "App") { Console.Clear(); goto Menu_Admin_App;}
            else { Console.Clear(); goto Menu_Admin_Local; }




            Menu_Admin_Local:
            Metodos.MenuAdmin_Local();
            string opc = Console.ReadLine();
            if (opc=="1")
            {
                //agregar oferta
                Console.Clear();
                Console.WriteLine("Proximamente...");
                goto Menu_Admin_Local;
            }
            else if (opc=="2")
            {
                //quitar oferta
                Console.Clear();
                Console.WriteLine("Proximamente");
                goto Menu_Admin_Local;
            }
            else if (opc=="3")
            {
                //modificar menu
                Console.Clear();
                Console.WriteLine("Proximamente...");
                goto Menu_Admin_Local;
            }
            else if (opc=="4")
            {
                Console.Clear();
                goto Menu_User;
            }
            else if (opc == "5")
            {
                Cierra_a = DateTime.Now;
                registroLog_a.Add(Cierra_a);
                Metodos.Logging(registroLog_a, registro_log, login_a);
                goto Inicio;
            }

            Menu_Admin_App:
            Metodos.MenuAdmin_App();
            string opci = Console.ReadLine();
            if (opci == "1")
            {
                //agregar local
                Console.Write("Nombre del local: ");
                string nombre_local = Console.ReadLine();
                Console.Write("\nRut del Local: ");
                string rut_local = Console.ReadLine();
                Console.Write("\nHora de apertura (hora:min): ");
                string abre = Console.ReadLine();
                string[] hora_a = abre.Split(':');
                DateTime Abre = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(hora_a[0]), Convert.ToInt32(hora_a[1]), 0);
                Console.Write("\nHora de cierre (hora:min): ");
                string cierra = Console.ReadLine();
                string[] hora_c = cierra.Split(':');
                DateTime Cierra = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, Convert.ToInt32(hora_c[0]), Convert.ToInt32(hora_c[1]), 0);
                Local seAgrega = new Local(nombre_local, rut_local, Abre, Cierra);
                locales.Add(seAgrega);
            }
            else if (opci == "2")
            {
                //quitar local
                Console.Write("Nombre del local: ");
                string nombre = Console.ReadLine();
                Local aQuitar = Metodos.BuscaLocal(nombre, locales);
                locales.Remove(aQuitar);
            }
            else if (opci == "3")
            {
                //quitar user
                Console.Write("Mail del user a quitar: ");
                string mail = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Usuario: " + mail + "fue removido con extio...");
                Console.ForegroundColor = ConsoleColor.White;
                goto Menu_Admin_App;
            }
            else if (opci == "4")
            {
                //cambiar admin
                Console.WriteLine("Proximamente...");
                goto Menu_Admin_App;
                //no implementado
            }
            else if (opci == "5")
            {
                Console.Clear();
                goto Menu_User;
            }

            else if (opci == "6")
            {
                Cierra_a = DateTime.Now;
                registroLog_a.Add(Cierra_a);
                Metodos.Logging(registroLog_a, registro_log, login_a);
                goto Inicio;
            }

            Fin:


            Metodos.EscribeArchivoUsers(registro_admin_app, admins_app);
            registro_admin_app.Close();

            Metodos.EscribeArchivoUsers(registro_admin_local, admins_local);
            registro_admin_local.Close();

            Metodos.EscribeArchivoUsers(registro_usuarios, usuarios);
            registro_usuarios.Close();
            registro_log.Close();
            Console.WriteLine("Press any key to Exit...");
            Console.ReadKey();
        }
    }
}