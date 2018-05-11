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
    public partial class SetSales : Form
    {
        public SetSales()
        {
            InitializeComponent();
            CLocal.Items.Clear();
            CLocal.Items.Add(AUser.AdminLocalA.GetLocal());
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

        private void BSale_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            try
            {
                string lugar = CLocal.SelectedItem.ToString();
                string prod = CProducto.SelectedItem.ToString();
                int precio_oferta = Convert.ToInt32(TPrecio.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al agregar oferta\n" +exc.Message , "Error");
                hay_error = true;
            }
            if (hay_error == false)
            {
                string lugar = CLocal.SelectedItem.ToString();
                string prod = CProducto.SelectedItem.ToString();
                int precio_oferta = Convert.ToInt32(TPrecio.Text);
                AdminLocal admin = AUser.AdminLocalA;
                List<Local> locales = Metodos.DeserializarLocal();
                admin.AgregarOferta(Metodos.BuscaProducto(Metodos.BuscaLocal(lugar, locales).GetMenu(), prod));
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            MainAdminLocal a = new MainAdminLocal();
            this.Close();
            a.Show();
        }
    }
}
