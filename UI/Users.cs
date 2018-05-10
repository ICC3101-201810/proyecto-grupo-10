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

        public bool RealizarPedido(List<Local> locales, string elige_local, string id, int cantidad, int medioPago)
        {
            Local local = Metodos.BuscaLocal(elige_local, locales);
            if (local == null)
            {
                return false;
            }
            List<Producto> Menu_Local = local.GetMenu();
            Producto comida = Metodos.BuscaProducto(Menu_Local, id);
            if (comida == null)
            {
                return false;
            }
            int IDPedido = local.GeneraID();
            if (medioPago == 1)
            {
                string pedido = "Pedido numero: " + IDPedido + "Nombre: " + this.GetName() + this.apellido + "Item: " + comida.GetNombre() + "ID_Item: "+ comida.GetID() + "Cantidad: " + cantidad.ToString() + "Monto a pagado: " + (cantidad * comida.GetPrecio()).ToString();
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
                string pedido = "Pedido numero: " + IDPedido + "Nombre: " + this.GetName() + this.apellido + "Item: " + comida.GetNombre() + "ID_Item: " + comida.GetID() + "Cantidad: " + cantidad.ToString() + "Monto a pagar: " + (cantidad * comida.GetPrecio()).ToString();
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
