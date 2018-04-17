using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoVVSS
{
    class Local
    {
        string nombre;
        string rut;
        List<string> comentarios;
        List<Producto> menu;
        DateTime hora_apertura;
        DateTime hora_cierre;
        public Local(string Nombre,string Rut, DateTime Abre, DateTime Cierra)
        {
            nombre = Nombre;
            rut = Rut;
            hora_apertura = Abre;
            hora_cierre = Cierra;
            menu = new List<Producto>();
            comentarios = new List<string>();
        }
        public string ImprimeHorario()
        {
            return "Abre: " + this.hora_apertura.Hour + ":" + this.hora_apertura.Minute + "\nCierra: " + this.hora_apertura.Hour + ":" + this.hora_apertura.Minute;
        }
        public void ImprimeMenu()
        {
            Console.WriteLine("Producto\t\tPrecio");
            foreach (Producto item in this.menu)
            {
                Console.WriteLine(item.GetNombre().ToUpper() + "\t\t" + item.GetPrecio().ToString());
            }
        }

    }
}
