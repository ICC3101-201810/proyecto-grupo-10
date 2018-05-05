using System;
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
            //List<Users> usuarios = Metodos.DeserializarUsers();
            //List<AdminApp> admins_app = Metodos.DeserializarAdminsApp();
            //List<AdminLocal> admins_local = Metodos.DeserializarAdminsLocal();
            //List<Local> locales = Metodos.DeserializarLocal();
            //List<string> Log = Metodos.DeserializaLog();
            List<Users> usuarios = new List<Users>();
            List<AdminLocal> admins_local = new List<AdminLocal>();
            List <AdminApp> admins_app = new List<AdminApp>();

            Users user1 = new Users("prueba@miuandes.cl", "12345", "prueba", "uno", "rut", 0);
            usuarios.Add(user1);
            AdminLocal prueba = new AdminLocal("adminLocal@miuandes.cl", "1243", "admin", "local 1", "1234-5", 0);
            admins_local.Add(prueba);
            AdminApp hugo = new AdminApp("hadelafuente@miuandes.cl", "1234", "Hugo", "de la Fuente", "19889338-2", 1000000);
            admins_app.Add(hugo);
            //solo implementado para admin de app
            /*SoloAdmins:
            Mensaje("Admins");
            Console.WriteLine("Deje este campo vacio para volver");
            Console.Write("Correo: ");
            string correo = Console.ReadLine();
            if (correo == "")
            {
                Console.Clear();
                goto SoloAdmins;
            }
            Console.Write("Contraseña: ");
            string clave = Console.ReadLine();
            if (Metodos.VerificaMail(correo))
            {
                Console.Clear();
                goto Loguea_Admin;
            }
            else
            {
                Console.Clear();
                Mensaje("Proyecto VVSS");
                Console.WriteLine("Correo Invalido...");
                goto SoloAdmins;
            }


            Loguea_Admin:
            List<DateTime> registroLog_a = new List<DateTime>();
            AdminApp login_a = Metodos.LogInAdminApp(admins_app, correo, clave);
            if (login_a == null)
            {

                Console.Clear();
                Console.WriteLine("Usuario invalido...");
                goto SoloAdmins;
            }


            Menu_Admin_App:
            DateTime inicio_a = DateTime.Now;
            registroLog_a.Add(inicio_a);
            DateTime Cierra_a;
            Metodos.MenuAdmin_App();
            string opci = Console.ReadLine();
            if (opci == "1")
            {
                //agregar local
                Console.WriteLine("implementar metodo");
            }
            else if (opci == "2")
            {
                //quitar local
                Console.WriteLine("implementar metodo");
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
                Metodos.RegistrarAdmin(admins_app);
                goto Menu_Admin_App;
            }
            else if (opci == "5")
            {
                Console.Clear();
                goto SoloAdmins;
            }

            else if (opci == "6")
            {
                Cierra_a = DateTime.Now;
                registroLog_a.Add(Cierra_a);
                Metodos.WriteLog(login_a, Log, registroLog_a);
                
            }*/


            Metodos.SerializarAdminsApp(admins_app);
            Metodos.SerializarUsers(usuarios);
            Metodos.SerializarAdminsLocal(admins_local);
            //Metodos.SerializaLog(Log);
            //Metodos.SerializarLocal(locales);
            Console.WriteLine("Press any key to Exit...");
            Console.ReadKey();
        }
    }
}
