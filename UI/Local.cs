using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    [Serializable]
    public class Local
    {
        string nombre;
        string rut;
        List<Ranking> comentarios;
        public List<Producto> menu;
        public List<DateTime> horario;
        List<string> pedidos;
        public List<Producto> ofertas;
        public Local(string Nombre, string Rut, DateTime abre, DateTime cierra)
        {
            nombre = Nombre;
            rut = Rut;
            menu = new List<Producto>();
            comentarios = new List<Ranking>();
            horario = new List<DateTime> { abre, cierra };
            pedidos = new List<string>();
        }
        public string GetName()
        {
            return this.nombre;
        }
        public string GetRut()
        {
            return this.rut;
        }
        public string ImprimeHorario()
        {
            return "Abre: " + this.horario[0].Hour + ":" + this.horario[0].Minute + "Cierra: " + this.horario[1].Hour + ":" + this.horario[1].Minute;
        }
        public void ImprimeMenu()
        {
            foreach (Producto item in this.menu)
            {
                Console.WriteLine(item.GetNombre().ToUpper() + "\t\t" + item.GetPrecio().ToString() + "\t\t" + item.GetID());
            }
        }
        public List<DateTime> GetHorario()
        {
            return this.horario;
        }

        public List<Producto> GetMenu()
        {
            return this.menu;
        }

        public void RecibeNota(Ranking rank)
        {
            comentarios.Add(rank);
        }
        public void RecibePedido(string pedido)
        {
            pedidos.Add(pedido);
        }
        public void RecibeProducto(Producto item)
        {
            menu.Add(item);
        }
        public int GeneraID()
        {
            return pedidos.Count + 1;
        }
        public List<Ranking> GetRank()
        {
            return this.comentarios;
        }
        public double PromedioRanking(List<Ranking> rank)
        {
            double total = rank.Count();
            double suma = 0.0;
            foreach (Ranking r1 in rank)
            {
                suma += r1.GetNota();
            }
            return suma / total;
        }
    }
}
