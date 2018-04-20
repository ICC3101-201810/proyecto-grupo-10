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
            List<Users> usuarios = Metodos.GetUsuarios(@"usuarios.txt");
            List<Users> admins_app = Metodos.GetAdmin(@"admin_app.txt");
            List<Local> locales = Metodos.GetLocales(@"locales.txt");
            Console.WriteLine(locales.Count);
            /*Archivos txt donde se almacena informacion con usuarios, admins, locales, etc... */
            /*FileStream registro_usuarios = new FileStream(Metodos.GetDirectrio(@"usuarios.txt"), FileMode.OpenOrCreate,FileAccess.ReadWrite, FileShare.None);*/
            /*FileStream registro_admin_app = new FileStream(Metodos.GetDirectrio(@"admin_app.txt"), FileMode.OpenOrCreate,FileAccess.ReadWrite, FileShare.None);*/
            /*FileStream registro_admin_local = new FileStream(Metodos.GetDirectrio(@"admin_local.txt"), FileMode.OpenOrCreate,FileAccess.ReadWrite, FileShare.None);*/
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
                Console.WriteLine("Correo Invalido...");
                goto Ingresar;
            }


            Registrar:
            //registro de user
            Metodos.Registra(usuarios);
            goto Ingresar;


            Loguea:
            List<DateTime> Log = new List<DateTime>();
            Users login_1 = Metodos.Log_In(usuarios, correo, clave);
            DateTime inicio = DateTime.Now;
            Log.Add(inicio);
            DateTime Cierra;
            if (login_1.GetName()==null)
            {

                Console.Clear();
                Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
                Console.WriteLine("Usuario no encontrado, por favor registrese...");
                goto Registrar;
            }


            Menu_User:
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
                    Console.WriteLine("No se encontraron opciones para el monto: {0}", presu);
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
                if (selecionado == null) { Console.Clear();  Console.WriteLine("Local no existe..."); goto Menu_User; }
                selecionado.ImprimeMenu();
                Console.Write("Seleccione el ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Producto comida = Metodos.BuscaProducto(selecionado.GetMenu(), id);
                if (comida == null) { Console.Clear(); Console.WriteLine("Producto no encontrado..."); goto Menu_User; }
                Console.Write("Cuant@s: ");
                int q = Convert.ToInt32(Console.ReadLine());
                bool realiza=login.RealizarPedido(comida, selecionado,q);
                if (realiza==false)
                {
                    Console.Clear();
                    Console.WriteLine("Error en el pedido...");
                    goto Menu_User;
                }
                Console.WriteLine("Pedido realizado con exito...");

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
                Cierra = DateTime.Now;
                Log.Add(Cierra);
                Metodos.Logging(Log, registro_log, login);
                goto Inicio;
            }

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

            }
            else if (opc=="2")
            {

            }
            else if (opc=="3")
            {

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
            if (opci == "6")
            {
                Cierra_a = DateTime.Now;
                registroLog_a.Add(Cierra_a);
                Metodos.Logging(registroLog_a, registro_log, login_a);
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
