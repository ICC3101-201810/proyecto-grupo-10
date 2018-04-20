using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProyectoVVSS
{
    class Users
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
        /*Getters*/
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

        public bool RealizarPedido(Producto comida, Local local, int cantidad)
        {
            string pedido = "Nombre: " + this.GetName() + this.apellido + "Item: " + comida.GetNombre() + "Cantidad: " + cantidad.ToString() + "Monto a pagar: " + (cantidad * comida.GetPrecio()).ToString();
            if (comida.GetStock()>=cantidad && comida.GetPrecio()<= this.saldo)
            {
                local.RecibePedido(pedido);
                saldo -= comida.GetPrecio() * cantidad;
                return true;
            }
            return false;
            
        }
        public List<Producto> Presupuestar(Local local, int presupuesto)
        {
            List<Producto> Out = new List<Producto>();
            IEnumerable<Producto> Opciones = local.GetMenu().Where(producto => producto.GetPrecio() <= presupuesto);
            foreach (Producto item in Opciones)
            {
                Out.Add(item);
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
