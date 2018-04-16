using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoVVSS
{
    class Producto
    {
        string nombre;
        int precio;
        int stock;
        int id;
        public Producto(string Nombre, int Precio, int Stock, int ID)
        {
            nombre = Nombre;
            precio = Precio;
            stock = Stock;
            id = ID;
        }
        public int GetPrecio()
        {
            return this.precio;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
    }
}
