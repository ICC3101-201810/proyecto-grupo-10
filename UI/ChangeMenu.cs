using System;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAdminLocal a = new MainAdminLocal();
            a.Show();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            string Nombre = TNombre.Text;
            string Precio = TPrecio.Text;
            int Stock = Int32.Parse(TStock.Text);
            int Id = Int32.Parse(TId.Text);
            this.Hide();
            MainAdminLocal a = new MainAdminLocal();
            a.Show();
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
            CProducto.ResetText();
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
