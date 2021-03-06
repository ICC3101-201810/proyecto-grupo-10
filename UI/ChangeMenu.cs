﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ChangeMenu : Form
    {
        public ChangeMenu()
        {
            InitializeComponent();
            List<Local> locales = Metodos.DeserializarLocal();
            foreach (Local l in locales)
            {
                CLocal.Items.Add(l.GetName());
            }
            Metodos.SerializarLocal(locales);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            try
            {
                string Nombre = TNombre.Text;
                string Precio = TPrecio.Text;
                int Stock = Int32.Parse(TStock.Text);
                int Id = Int32.Parse(TId.Text);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error al agregar producto\n" + exc.Message, "Error");
                hay_error = true;
            }
            if (hay_error==false)
            {
                string local = CLocal.SelectedItem.ToString();
                List<Local> locales = Metodos.DeserializarLocal();
                Local lugar = Metodos.BuscaLocal(local, locales);
                string Nombre = TNombre.Text;
                int Precio = Convert.ToInt32(TPrecio.Text);
                int Stock = Int32.Parse(TStock.Text);
                int Id = Int32.Parse(TId.Text);
                AdminLocal adminLocal = AUser.AdminLocalA;
                adminLocal.AgregarAlMenu(lugar, Nombre, Precio, Stock);
                Metodos.SerializarLocal(locales);
                MessageBox.Show("Producto agregado con exito!");
                this.Close();
                MainAdminLocal a = new MainAdminLocal();
                a.Show();
            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            try
            {
                string prod = CProducto.SelectedItem.ToString();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error al remover producto\n" + exc.Message, "Error");
                hay_error = true;
            }
            if (hay_error == false)
            {
                string prod = CProducto.SelectedItem.ToString();
                List<Local> locales = Metodos.DeserializarLocal();
                AdminLocal admin = AUser.AdminLocalA;
                Producto aremover = Metodos.BuscaProducto(admin.GetLocal().menu, prod);
                admin.QuitarDelMenu(aremover);
                MessageBox.Show("Product removed!");

                this.Hide();
                Metodos.SerializarLocal(locales);
                MainAdminLocal a = new MainAdminLocal();
                a.Show();
            }
        }

        private void ChangeMenu_Load(object sender, EventArgs e)
        {

        }

        private void CLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CProducto.Items.Clear();
            List<Local> locales = Metodos.DeserializarLocal();
            string elige_local = CLocal.SelectedItem.ToString();
            Local Lugar = Metodos.BuscaLocal(elige_local, locales);
            List<Producto> Opciones = Lugar.GetMenu();
            foreach (Producto item in Opciones)
            {
                CProducto.Items.Add(item.GetNombre());
            }
            Metodos.SerializarLocal(locales);
        }
    }
}
