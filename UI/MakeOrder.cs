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
    public partial class MakeOrder : Form
    {
        public MakeOrder()
        {
            InitializeComponent();
            List<Local> locales = Metodos.DeserializarLocal();
            foreach (Local l in locales)
            {
                CLocal.Items.Add(l.GetName());
            }
            Metodos.SerializarLocal(locales);
        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {

        }

        private void BBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BCredito_Click(object sender, EventArgs e)
        {
            List<Local> locales = Metodos.DeserializarLocal();
            List<Users> usuarios = Metodos.DeserializarUsers();
            bool hay_error = false;
            try
            {
                string elige_local = CLocal.Text;
                string elige_producto = LProducto.Text;
                int Cantidad = Convert.ToInt32(ICantidad.Text);
            }
            catch(Exception exc)
            {
                MessageBox.Show("No relleno todos los campos\n" + exc.Message, "Error");
                Metodos.SerializarLocal(locales);
                hay_error = true;
            }
            if (hay_error == false)
            {
                int MedioPago = 1;
                string elige_local = CLocal.SelectedItem.ToString();
                Local Lugar = Metodos.BuscaLocal(elige_local, locales);
                string elige_producto = CProducto.SelectedItem.ToString();
                int Cantidad = Convert.ToInt32(ICantidad.Text);
                Users UsuarioActivo = AUser.UsuarioA;
                int numero = Metodos.BuscaIndiceUser(usuarios, UsuarioActivo);
                if (UsuarioActivo.RealizarPedido(locales, elige_local, elige_producto, Cantidad, MedioPago))
                {
                    MessageBox.Show("Pedido Realizado con exito!");
                    Metodos.SerializarLocal(locales);
                    usuarios[numero].RealizarPedido(locales, elige_local, elige_producto, Cantidad, MedioPago);
                    Metodos.SerializarUsers(usuarios);
                    MainAplicacion main = new MainAplicacion();
                    main.Show();
                    this.Close();
                }
                else MessageBox.Show("Error en realizar pedido","Error");
                Metodos.SerializarLocal(locales);
                Metodos.SerializarUsers(usuarios);
            }
        }

        private void BTienda_Click(object sender, EventArgs e)
        {
            int MedioPago = 2;
            List<Local> locales = Metodos.DeserializarLocal();
            bool hay_error = false;
            try
            {
                string elige_local = CLocal.Text;
                string elige_producto = LProducto.Text;
                int Cantidad = Convert.ToInt32(ICantidad.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("No relleno todos los campos\n" + exc.Message, "Error");
                Metodos.SerializarLocal(locales);
                hay_error = true;
            }
            if (hay_error == false)
            {
                string elige_local = CLocal.SelectedItem.ToString();
                Local Lugar = Metodos.BuscaLocal(elige_local, locales);
                string elige_producto = CProducto.SelectedItem.ToString();
                int Cantidad = Convert.ToInt32(ICantidad.Text);
                Users UsuarioActivo = AUser.UsuarioA;
                if (UsuarioActivo.RealizarPedido(locales, elige_local, elige_producto, Cantidad, MedioPago))
                {
                    UsuarioActivo.RealizarPedido(locales, elige_local, elige_producto, Cantidad, MedioPago);
                    MessageBox.Show("Pedido Realizado con exito!");
                    Metodos.SerializarLocal(locales);
                    MainAplicacion main = new MainAplicacion();
                    main.Show();
                    this.Close();
                }
                else MessageBox.Show("Error en realizar pedido", "Error");
                Metodos.SerializarLocal(locales);

            }
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
