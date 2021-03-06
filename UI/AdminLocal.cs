﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    [Serializable]
    public class AdminLocal : Users
    {
        Local local;
        public AdminLocal(string Mail, string miPass, string miNombre, string miApellido, string miRut, int miSaldo, Local lugar) : base(miNombre, miApellido, miRut, miPass, Mail, miSaldo)
        {
            local = lugar;
        }
        public AdminLocal(string Mail, string miPass, string miNombre, string miApellido, string miRut, int miSaldo) : base(miNombre, miApellido, miRut, miPass, Mail, miSaldo)
        {
        }
        public void SetLocal(Local lugar)
        {
            local = lugar;
        }
        public Local GetLocal()
        {
            return this.local;
        }

        public List<DateTime> DefineHorario(int hora_abre, int minuto_abre, int hora_cierra, int minuto_cierra)
        {
            DateTime dia = DateTime.Now;
            DateTime apertura = new DateTime(dia.Year, dia.Month, dia.Day, hora_abre, minuto_abre, 0);
            DateTime cierre = new DateTime(dia.Year, dia.Month, dia.Day, hora_cierra, minuto_cierra, 0);
            List<DateTime> horario = new List<DateTime> { apertura, cierre };
            return horario;
        }
        public void AgregarAlMenu(Local lugar, string nombre, int precio, int stock)
        {
            List<Producto> menu = lugar.GetMenu();
            Producto plato = new Producto(nombre, precio, stock, menu.Count + 1);
            lugar.RecibeProducto(plato);
        }
        public void AgregarOferta(Producto item)
        {
            Local local = this.GetLocal();
            try
            {
                local.ofertas.Add(item);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Setting sale failed\n" + exc.Message, "Sale error");
            }
        }
        public void QuitarOferta()
        {

        }
        public void QuitarDelMenu(Producto item)
        {
            this.local.GetMenu().Remove(item);
        }

    }
}
