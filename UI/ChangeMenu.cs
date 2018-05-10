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
            MainAdminLocal a = new MainAdminLocal;
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
            this.Hide();
            MainAdminLocal a = new MainAdminLocal();
            a.Show();
        }
    }
}
