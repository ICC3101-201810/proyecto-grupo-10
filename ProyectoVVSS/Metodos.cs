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
            Console.Clear();
            Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
            Console.Write("Bienvenido " + login.GetName() + "!\n" +
                "1.Ingresar Presupuesto y ver opciones\n" +
                "2.Ver Locales disponibles\n" +
                "3.Asignar nota o comentario a local\n" + "4.Realizar Pedido\n" + "5.Abonar Saldo\n" +
                "6.Cerrar Sesion\nOpcion: ");
        }

        public static void MenuAdmin_Local() //Imprime menu de admin de local
        {
            Console.Clear();
            Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
            Console.Write("1.Agregar Oferta\n2.Quitar Oferta\n3.Modificar Menu\n4.Usar aplicacion como usuario normal\n5.Cerrar Sesion\nOpcion: ");
        }
        public static void MenuAdmin_App() //Imprime menu para admin de la app
        {
            Console.Clear();
            Console.WriteLine("\n---------------------------\n Proyecto VVSS\n---------------------------\n");
            Console.Write("1.Agregar Local\n2.Quitar Local\n3.Quitar Usuario\n4.Cambiar Admin de Local\n 5.Usar aplicacion como usuario normal\n6.Cerrar Sesion\nOpcion: ");
        }
        public List<Local> LocalesAbiertos(List<Local> locales)
        { 
            List<Local> lugaresAbietos = new List<Local>();
            IEnumerable<Local> abiertos = locales.Where(lugar => lugar.GetHorario()[0].Hour < DateTime.Now.Hour && DateTime.Now.Hour < lugar.GetHorario()[1].Hour);
            foreach (Local lugar in abiertos)
            {
                lugaresAbietos.Add(lugar);
            }
            return lugaresAbietos;
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
        
        
    }
}
