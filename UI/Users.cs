using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    [Serializable]
    public class Users
    {
        string nombre;
        string apellido;
        string rut;
        string password;
        string mail;
        int saldo;
        public Users(string Mail, string miPass, string miNombre, string miApellido, string miRut, int miSaldo)
        {
            nombre = miNombre;
            apellido = miApellido;
            rut = miRut;
            password = miPass;
            mail = Mail;
            saldo = miSaldo;
        }
        public int GetSaldo()
        {
            return this.saldo;
        }

        public virtual string GetName()
        {
            return this.nombre;
        }

        public void Abonar(int numero)
        {
            saldo += numero;
        }

        public virtual string GetMail()
        {
            return this.mail;
        }

        public bool CheckPass(string Ipas)
        {
            return this.password.Equals(Ipas);
        }

        public virtual string Info()
        {
            return this.mail + ',' + this.password + ',' + this.nombre + ',' + this.apellido + ',' + this.rut + ',' + this.saldo;
        }

        public bool RealizarPedido(List<Local> locales)
        {
            Console.Clear();
            string elige_local = Console.ReadLine();
            Local local = Metodos.BuscaLocal(elige_local, locales);
            if (local == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Local no existe...");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            local.ImprimeMenu();
            Console.Write("Seleccione el ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Producto comida = Metodos.BuscaProducto(local.GetMenu(), id);
            if (comida == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto no encontrado...");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            Console.Write("Cuant@s: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Paga con saldo\n2.Paga en local\nOpcion: ");
            int IDPedido = local.GeneraID();
            int medioPago = Convert.ToInt32(Console.ReadLine());
            if (medioPago == 1)
            {
                string pedido = "Pedido numero: " + IDPedido + "Nombre: " + this.GetName() + this.apellido + "Item: " + comida.GetNombre() + "Cantidad: " + cantidad.ToString() + "Monto a pagado: " + (cantidad * comida.GetPrecio()).ToString();
                if (comida.GetStock() >= cantidad && comida.GetPrecio() <= this.saldo)
                {
                    local.RecibePedido(pedido);
                    saldo -= comida.GetPrecio() * cantidad;
                    return true;
                }
                return false;
            }
            else
            {
                string pedido = "Pedido numero: " + IDPedido + "Nombre: " + this.GetName() + this.apellido + "Item: " + comida.GetNombre() + "Cantidad: " + cantidad.ToString() + "Monto a pagar: " + (cantidad * comida.GetPrecio()).ToString();
                if (comida.GetStock() >= cantidad)
                {
                    local.RecibePedido(pedido);
                    return true;
                }
                return false;
            }
        }

        public List<Producto> Presupuestar(List<Local> locales, int presupuesto)
        {
            if (presupuesto == 0)
            {
                return null;
            }
            List<Producto> Out = new List<Producto>();
            foreach (Local local in locales)
            {
                IEnumerable<Producto> Opciones = local.GetMenu().Where(producto => producto.GetPrecio() <= presupuesto);
                foreach (Producto item in Opciones)
                {
                    Out.Add(item);
                }
            }

            return Out;
        }

        public void SetNota(Local local, double nota, string comentario)
        {
            Ranking asigname = new Ranking(local, nota, comentario);
            local.RecibeNota(asigname);
        }
    }
}
