using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoVVSS
{
    class Local
    {
        string nombre;
        List<string> comentarios;
        List<Producto> menu;
        DateTime hora_apertura;
        DateTime hora_cierre;
        public Local(string Nombre, DateTime Abre, DateTime Cierra)
        {
            nombre = Nombre;
            hora_apertura = Abre;
            hora_cierre = Cierra;
            menu = new List<Producto>();
            comentarios = new List<string>();
        }
        public string GetHorario()
        {
            return "Abre: " + this.hora_apertura.Hour + ":" + this.hora_apertura.Minute + "\nCierra: " + this.hora_apertura.Hour + ":" + this.hora_apertura.Minute;
        }
        public void GetMenu()
        {
            Console.WriteLine("Producto\tPrecio");
            foreach (Producto item in this.menu)
            {
                Console.WriteLine(item.GetNombre().ToUpper() + "\t" + item.GetPrecio().ToString());
            }
        }
    }
}
