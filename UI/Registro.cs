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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BRegistrar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            string Nombre = TNombre.Text;
            string Apellido = TAppellido.Text;
            string Rut = TRut.Text;
            string Mail = TMail.Text;
            if (Metodos.VerificaMail(Mail)==false)
            {
                MessageBox.Show("Ingrese un mail valido", "Error de registro");
            }
            string Clave = TClave.Text;
            int Saldo = 0; //al registrar usuario el saldo por defecto es 0
            Users NewUser = new Users(Mail, Clave, Nombre, Apellido, Rut, Saldo);
            List<Users> usuarios = Metodos.DeserializarUsers();
            foreach (Users persona in usuarios)
            {
                if (persona.GetMail()==NewUser.GetMail())
                {
                    MessageBox.Show("Usuario ya esta registrado", "Error de registro");
                    menu.Show();
                    this.Close();
                }
            }
            usuarios.Add(NewUser);
            MessageBox.Show("Usuario registrado con exito!");
            Metodos.SerializarUsers(usuarios);
            this.Close();
            menu.Show();

        }

        private void BAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();

        }
    }
}
