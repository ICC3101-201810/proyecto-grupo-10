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
            Bienvenida.Text += "Bienvenido " + AUser.UsuarioA.GetName() + "\nSaldo disponible: $" + AUser.UsuarioA.GetSaldo();
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
            foreach (Local lugar in locales)
            {
                mensaje += lugar.GetName() + ", Promedio: " +lugar.PromedioRanking(lugar.GetRank()) + "\n";
            }
            MessageBox.Show(mensaje, "Locales Disponibles");
            Metodos.SerializarLocal(locales);
        }

        private void ASaldo_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            List<Users> usuarios = Metodos.DeserializarUsers();
            string mail = AUser.Usuario.GetMail();
            Users Usuario_Activo = Metodos.BuscaUsuario(usuarios, mail);
            try
            {
                int saldo = Convert.ToInt32(ISaldo.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ingrese un monto valido\n" + exc.Message, "Error en presupuestacion");
                hay_error = true;
                Metodos.SerializarUsers(usuarios);
            }
            if (hay_error==false)
            {
                int saldo = Convert.ToInt32(ISaldo.Text);
                Usuario_Activo.Abonar(saldo);
                MessageBox.Show("Abono realizado con exito!");
                Metodos.SerializarUsers(usuarios);
            }


        }

        private void IPresupuesto_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            try
            {
                int budget = Convert.ToInt32(IBudget.Text);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Ingrese un monto valido\n" + exc.Message, "Error en presupuestacion");
                hay_error = true;
            }
            if (hay_error==false)
            {
                int budget_2 = Convert.ToInt32(IBudget.Text);
                List<Local> locales = Metodos.DeserializarLocal();
                Users Uactual = AUser.UsuarioA;
                List<Producto> Opciones = Uactual.Presupuestar(locales, budget_2);
                string mensaje = "";
                foreach (Producto item in Opciones)
                {
                    mensaje += "Producto: " + item.GetNombre() + " Precio: " + item.GetPrecio() + "\n";
                }
                MessageBox.Show(mensaje, "Productos Disponibles");
            }
            
        }

        private void RPedido_Click(object sender, EventArgs e)
        {
            MakeOrder a = new MakeOrder();
            this.Close();
            a.Show();
        }
    }
}
