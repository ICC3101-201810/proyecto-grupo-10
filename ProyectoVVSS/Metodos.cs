using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ProyectoVVSS
{
    class Metodos
    {
        /***************************************************************/
        /*                                                             */
        /*           Metodos y Funciones usados en main                */
        /*                                                             */
        /***************************************************************/

        public static void MenuUser(Users login) //menu para el usuario regular
        {
            Console.Write("Bienvenido " + login.GetName() + "!\n" +
                "1.Ingresar Presupuesto y ver opciones\n" +
                "2.Ver Locales disponibles\n" +
                "3.Asignar nota o comentario a local\n" + "4.Realizar Pedido\n" + "5.Abonar Saldo\n" +
                "6.Cerrar Sesion\nOpcion: ");
        }


        public static void MenuAdmin_Local() //Imprime menu de admin de local
        {
            Console.Write("1.Agregar Oferta\n2.Quitar Oferta\n3.Modificar Menu\n4.Usar aplicacion como usuario normal\n5.Cerrar Sesion\nOpcion: ");
        }
        public static void MenuAdmin_App() //Imprime menu para admin de la app
        {
            Console.Write("1.Agregar Local\n2.Quitar Local\n3.Quitar Usuario\n4.Cambiar Admin de Local\n 5.Usar aplicacion como usuario normal\n6.Cerrar Sesion\nOpcion: ");
        }



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

        public static void ImprimeLocalesAbiertos(List<Local> locales)
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
                if (item.GetID()==id)
                {
                    return item;
                }
            }
            return null;
        }




        public static bool Mail(string correo) //Comprueba que sea correo
        {
            string pat = "[A-Z]*[a-z]*@[a-z]*[A-Z]*.[A-Z]*[a-z]*";
            Regex r = new Regex(pat);
            Match m = r.Match(correo);
            return m.Success;
        }
        public static bool VerificaMail(string correo) //Comprueba que sea @miUandes.cl
        {
            string verifica = "@miuandes.cl";
            int temp = verifica.Length - 1;
            for (int i = correo.Length - 1; i != 0; i--)
            {
                if (temp == 0)
                {
                    break;
                }
                else
                {
                    if (correo[i] == verifica[temp])
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



        public static string GetDirectrio(string archivo) //obtiene el path de los archivos de texto
        {
            string path_i = Directory.GetCurrentDirectory();
            string algo = @"bin\Debug\netcoreapp2.0";
            string path = "";
            int largo = (int)path_i.Length - 1;
            for (int i = 0; i <= largo - algo.Length; i++)
            {
                path += path_i[i];
            }
            path += archivo;
            return path;
        }
        public static List<Local> GetLocales(string archivo)
        {
            string path = GetDirectrio(archivo);
            string[] lineas = File.ReadAllLines(path);
            List<Local> output = new List<Local>();
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] actual = lineas[i].Split(',');
                DateTime abre = Convert.ToDateTime(actual[2]);
                DateTime cierra = Convert.ToDateTime(actual[3]);
                Local local_actual = new Local(actual[0], actual[1], abre, cierra);
                output.Add(local_actual);
            }
            return output;
        }

        public static List<Users> GetUsuarios(string archivo) //genera la lista con usuarios a partir del archivo especificado
        {
            string path_user = GetDirectrio(archivo);
            string[] texto_user = File.ReadAllLines(path_user);
            List<Users> usuarios = new List<Users>();
            for (int i = 0; i < texto_user.Length; i++)
            {
                string[] actual = texto_user[i].Split(',');
                Users actual_usuario = new Users(actual[0],actual[1],actual[2],actual[3],actual[4],Convert.ToInt32(actual[5]));
                usuarios.Add(actual_usuario);
            }
            return usuarios;
        }
        public static List<Users> GetAdmin(string archivo) //lo mismo para los admin
        {
            string path_user = GetDirectrio(archivo);
            string[] texto_user = File.ReadAllLines(path_user);
            List<Users> usuarios = new List<Users>();
            for (int i = 0; i < texto_user.Length; i++)
            {
                string[] actual = texto_user[i].Split(',');
                Users actual_usuario = new AdminApp(actual[0], actual[1], actual[2], actual[3], actual[4], Convert.ToInt32(actual[5]));
                usuarios.Add(actual_usuario);
            }
            return usuarios;
        }

        public static Users Log_In(List<Users> lista_users, string usuario_mail, string pass) //verifica al usuario dentro de la lista
        {
            IEnumerable<Users> Lista = lista_users.Where(us => us.GetMail() == usuario_mail && us.CheckPass(pass));
            foreach (Users elemento in Lista)
            {
                return elemento;
            }
            return null;
        }
        
        public static string DiferenciaAdmin(Users persona)
        {
            if(persona.GetType().ToString() == "ProyectoVVSS.AdminApp")
            {
                return "App";
            }
            else if (persona.GetType().ToString()== "ProyectoVVSS.AdminLocal")
            {
                return "Local";
            }
            return null;
        }
        public static void Logging(List<DateTime> ingreso, StreamWriter archivo, Users usuario)
        {
            string registro = usuario.GetName()+',' + usuario.GetMail() + ",Log-in:" + ingreso[0].ToString() + ",Log-out:" + ingreso[1].ToString();
            archivo.Write(registro);
        }
        public static void Registra(List<Users> usuarios)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("\nApellido: ");
            string apellido = Console.ReadLine();
            Here:
            Console.Write("\nCorreo: ");
            string mail = Console.ReadLine();
            if (Metodos.VerificaMail(mail) == false || Metodos.Mail(mail) == false) { Console.WriteLine("Correo Invalido..."); goto Here; }
            Console.Write("\nPassword: ");
            string pass = Console.ReadLine();
            Console.Write("\nRut: ");
            string Rut = Console.ReadLine();
            Users nuevo = new Users(mail, pass, nombre, apellido, Rut, 0);
            usuarios.Add(nuevo);
            Console.Clear();
            Console.WriteLine("Usuario creado, por favor inicie sesion ahora");
        }
        public static void EscribeArchivoUsers(StreamWriter archivo, List<Users> lista)
        {
            foreach (Users persona in lista)
            {
                archivo.Write("\n"+persona.Info());
            }
        }

        public static void EscribeArchivoUsers(StreamWriter archivo, List<Local> lista)
        {
            foreach (Local persona in lista)
            {
                archivo.Write(persona.GetName()+','+persona.GetRut()+','+persona.GetHorario()[0].ToString()+','+persona.GetHorario()[1].ToString());
            }
        }
    }
}
