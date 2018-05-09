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
    public partial class MainAplicacion : Form
    {
        public MainAplicacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ANota_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradesComm nn = new GradesComm();
            nn.Show();
        }

        private void VLocales_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            List<Local> locales = Metodos.DeserializarLocal();
            Producto cafe_grande = new Producto("Cafe Grande", 1200, 25, 1);
            Producto cafe_chico = new Producto("Cafe Chico", 890, 25, 2);
            foreach (Local lugar in locales)
            {
                mensaje += lugar.GetName() + ", Promedio: " +lugar.PromedioRanking(lugar.GetRank()) + "\n";
            }
            MessageBox.Show(mensaje, "Locales Disponibles");
            Metodos.SerializarLocal(locales);
        }

        private void ASaldo_Click(object sender, EventArgs e)
        {
            
        }

        private void IPresupuesto_Click(object sender, EventArgs e)
        {
            int budget = Convert.ToInt32(IBudget.Text);
            List<Local> locales = Metodos.DeserializarLocal();
            Users Uactual = AUser.UsuarioA;
            List<Producto> Opciones = Uactual.Presupuestar(locales, budget);
            string mensaje = "";
            foreach (Producto item in Opciones)
            {
                mensaje += "Producto: " + item.GetNombre() + " Precio: " + item.GetPrecio() + "\n"; 
            }
            MessageBox.Show(mensaje, "Productos Disponibles");
        }
    }
}
