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
        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {

        }

        private void BBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAplicacion a = new MainAplicacion();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BCredito_Click(object sender, EventArgs e)
        {
            int MedioPago = 1;
            string elige_local = CLocal.Text;
            string elige_producto = CProducto.Text;
        }

        private void BTienda_Click(object sender, EventArgs e)
        {
            int MedioPago = 2;
            string elige_local = CLocal.Text;
            string elige_producto = CProducto.Text;
        }
    }
}
