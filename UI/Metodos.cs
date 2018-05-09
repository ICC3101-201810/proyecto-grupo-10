using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace UI
{
    public class Metodos
    {
        /***************************************************************/
        /*           Metodos y Funciones usados en main                */
        /***************************************************************/
        public Users UsuarioActivo;
        public List<DateTime> UsuarioActivoLogIn= new List<DateTime> { DateTime.Now };

        public static List<Local> LocalesAbiertos(List<Local> locales)
        {
            List<Local> lugaresAbietos = new List<Local>();
            IEnumerable<Local> abiertos = locales.Where(lugar => lugar.GetHorario()[0].Hour < DateTime.Now.Hour && DateTime.Now.Hour < lugar.GetHorario()[1].Hour);
            foreach (Local lugar in abiertos)
            {
                lugaresAbietos.Add(lugar);
            }
            return lugaresAbietos;
        }

        public static void ImprimeLocalesAbiertos(List<Local> locales) //modificar para GUI
        {
            List<Local> Abiertos = Metodos.LocalesAbiertos(locales);
            Console.Clear();
            Console.WriteLine("\n---------------------------\nLocales Abiertos\n---------------------------\n");
            foreach (Local lugar in Abiertos)
            {
                Console.WriteLine(lugar.GetName() + " " + lugar.ImprimeHorario());
            }
            Console.WriteLine("\n---------------------------\n");
        }

        public static Local BuscaLocal(string nombre, List<Local> lista)
        {
            foreach (Local lugar in lista)
            {
                if (nombre == lugar.GetName())
                {
                    return lugar;
                }
            }
            return null;
        }

        public static Producto BuscaProducto(List<Producto> items, int id)
        {
            foreach (Producto item in items)
            {
                if (item.GetID() == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static bool VerificaMail(string correo) //comprueba que sea un correo
        {
            string pat = "[A-Z]*[a-z]*@miuandes.cl*";
            Regex r = new Regex(pat);
            Match m = r.Match(correo);
            return m.Success;
        }

        public static string GetDirectorio(string archivo) //obtiene el path del repositorio
        {
            string path_i = Directory.GetCurrentDirectory();
            string algo = @"bin";
            string path = "";
            int largo = (int)path_i.Length - 1;
            for (int i = 0; i <= largo - algo.Length; i++)
            {
                path += path_i[i];
            }
            path += archivo;
            return path;
        }

        /**************************************************/
        /*        Presistencia de la Informacion          */
        /**************************************************/
        public static void SerializarLocal(List<Local> lista_locales)
        {
            try
            {
                using (Stream stream = File.Open(GetDirectorio("locales.bin"), FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, lista_locales);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<Local> DeserializarLocal()
        {
            List<Local> locales;
            try
            {
                using (Stream stream = File.Open(GetDirectorio("locales.bin"), FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    locales = (List<Local>)bin.Deserialize(stream);
                }
                return locales;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void SerializarAdminsApp(List<AdminApp> usuarios)
        {
            try
            {
                using (Stream stream = File.Open(GetDirectorio("admin_app.bin"), FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, usuarios);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<AdminApp> DeserializarAdminsApp()
        {
            List<AdminApp> usuarios;
            try
            {
                using (Stream stream = File.Open(GetDirectorio("admin_app.bin"), FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    usuarios = (List<AdminApp>)bin.Deserialize(stream);
                }
                return usuarios;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void SerializarAdminsLocal(List<AdminLocal> usuarios)
        {
            try
            {
                using (Stream stream = File.Open(GetDirectorio("admin_local.bin"), FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, usuarios);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<AdminLocal> DeserializarAdminsLocal()
        {
            List<AdminLocal> usuarios;
            try
            {
                using (Stream stream = File.Open(GetDirectorio("admin_local.bin"), FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    usuarios = (List<AdminLocal>)bin.Deserialize(stream);
                }
                return usuarios;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public static void SerializarUsers(List<Users> usuarios)
        {
            try
            {
                using (Stream stream = File.Open(GetDirectorio("users.bin"), FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, usuarios);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static List<Users> DeserializarUsers()
        {
            List<Users> usuarios;
            try
            {
                using (Stream stream = File.Open(GetDirectorio("users.bin"), FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    usuarios = (List<Users>)bin.Deserialize(stream);
                }
                return usuarios;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void WriteLog(Users usuario, List<string> log, List<DateTime> ingreso) //genera string y se agrega a la lista para serializar el log
        {
            string registro = usuario.GetName() + ',' + usuario.GetMail() + ",Log-in:" + ingreso[0].ToString() + ",Log-out:" + ingreso[1].ToString() + ',' + usuario.GetType().ToString();
            try
            {
                log.Add(registro);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(registro);
            }

        }

        public static void SerializaLog(List<string> log)
        {
            try
            {
                using (Stream stream = File.Open(GetDirectorio("log.bin"), FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, log);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static List<string> DeserializaLog()
        {
            List<string> log;
            try
            {
                using (Stream stream = File.Open(GetDirectorio("log.bin"), FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    log = (List<string>)bin.Deserialize(stream);
                }
                return log;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /********************/
        /*     Log In       */
        /********************/
        public static Users Log_In(List<Users> lista_users, string usuario_mail, string pass) //verifica al usuario dentro de la lista
        {
            IEnumerable<Users> Lista = lista_users.Where(us => us.GetMail() == usuario_mail && us.CheckPass(pass));
            foreach (Users elemento in Lista)
            {
                return elemento;
            }
            return null;
        }

        public static AdminApp LogInAdminApp(List<AdminApp> lista_users, string usuario_mail, string pass) //verifica al usuario dentro de la lista
        {
            IEnumerable<AdminApp> Lista = lista_users.Where(us => us.GetMail() == usuario_mail && us.CheckPass(pass));
            foreach (AdminApp elemento in Lista)
            {
                return elemento;
            }
            return null;
        }

        public static AdminLocal LogInAdmin(List<AdminLocal> lista_users, string usuario_mail, string pass) //verifica al usuario dentro de la lista
        {
            IEnumerable<AdminLocal> Lista = lista_users.Where(us => us.GetMail() == usuario_mail && us.CheckPass(pass));
            foreach (AdminLocal elemento in Lista)
            {
                return elemento;
            }
            return null;
        }

        public static string DiferenciaAdmin(Users persona) //podria no ser utilizado
        {
            if (persona.GetType().ToString() == "ProyectoVVSS.AdminApp")
            {
                return "App";
            }
            else if (persona.GetType().ToString() == "ProyectoVVSS.AdminLocal")
            {
                return "Local";
            }
            return null;
        }

        public static bool RegistrarAdmin(List<AdminApp> usuarios) //modificar para GUI
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("\nApellido: ");
            string apellido = Console.ReadLine();
            Console.Write("\nCorreo: ");
            string mail = Console.ReadLine();
            if (Metodos.VerificaMail(mail) == false)
            {
                Console.WriteLine("Correo Invalido...");
                return false;
            }
            Console.Write("\nPassword: ");
            string pass = Console.ReadLine();
            Console.Write("\nRut: ");
            string Rut = Console.ReadLine();
            AdminApp nuevo = new AdminApp(mail, pass, nombre, apellido, Rut, 0);
            usuarios.Add(nuevo);
            Console.Clear();
            return true;
        }

        public static bool RegistrarUser(List<Users> usuarios) //modificar para GUI
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("\nApellido: ");
            string apellido = Console.ReadLine();
            Console.Write("\nCorreo: ");
            string mail = Console.ReadLine();
            if (Metodos.VerificaMail(mail) == false)
            {
                Console.WriteLine("Correo Invalido...");
                return false;
            }
            Console.Write("\nPassword: ");
            string pass = Console.ReadLine();
            Console.Write("\nRut: ");
            string Rut = Console.ReadLine();
            Users nuevo = new Users(mail, pass, nombre, apellido, Rut, 0);
            usuarios.Add(nuevo);
            Console.Clear();
            return true;
        }

        public static bool RegistrarAdmin(List<AdminLocal> usuarios) //modificar para GUI
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("\nApellido: ");
            string apellido = Console.ReadLine();
            Console.Write("\nCorreo: ");
            string mail = Console.ReadLine();
            if (Metodos.VerificaMail(mail) == false)
            {
                Console.WriteLine("Correo Invalido...");
                return false;
            }
            Console.Write("\nPassword: ");
            string pass = Console.ReadLine();
            Console.Write("\nRut: ");
            string Rut = Console.ReadLine();
            AdminLocal nuevo = new AdminLocal(mail, pass, nombre, apellido, Rut, 0);
            usuarios.Add(nuevo);
            Console.Clear();
            return true;
        }

    }
}
