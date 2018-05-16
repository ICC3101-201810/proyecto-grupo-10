using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace UI
{
    public class Metodos
    {
        /***************************************************************/
        /*           Metodos y Funciones usados en main                */
        /***************************************************************/
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
        public static int BuscaIndiceUser(List<Users> lista, Users usuario)
        {
            int contador = 0;
            foreach (Users persona in lista)
            {
                if (usuario.GetMail()==persona.GetMail())
                {
                    break;
                }
                contador++;
            }
            return contador;
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

        public static Producto BuscaProducto(List<Producto> items, string id)
        {
            foreach (Producto item in items)
            {
                if (item.GetNombre() == id)
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
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Delocales.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, lista_locales);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static List<Local> DeserializarLocal()
        {
            List<Local> locales;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Delocales.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    locales = (List<Local>)bin.Deserialize(stream);
                }
                return locales;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static void SerializarAdminsApp(List<AdminApp> usuarios)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Deadmin_app.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
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
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Deadmin_app.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
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
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Deadmin_local.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
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
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Deadmin_local");
                using (Stream stream = File.Open(path, FileMode.Open))
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
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Deusers.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
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
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Deusers.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
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
        public static Users BuscaUsuario(List<Users> lista_users, string usuario_mail)
        {
            IEnumerable<Users> Lista = lista_users.Where(us => us.GetMail() == usuario_mail);
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
    }
}
