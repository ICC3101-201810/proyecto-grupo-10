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
    public partial class MainAdminLocal : Form
    {
        public MainAdminLocal()
        {
            InitializeComponent();
            Bienvenida.Text += "Bienvenido " + AUser.AdminLocalA.GetName() + "\nSaldo disponible: $" + AUser.AdminLocalA.GetSaldo() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetSales sales = new SetSales();
            sales.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BCambioHorario_Click(object sender, EventArgs e)
        {
            Hours hora = new Hours();
            hora.Show();
        }

        private void BCambiarMenu_Click(object sender, EventArgs e)
        {
            ChangeMenu a = new ChangeMenu();
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
