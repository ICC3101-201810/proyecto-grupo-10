using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Sintaxis tomgar:(iniciales mayusculas) inicial primera palabra + segunda palabra, ejemplo: cerrar sesion = CSesion
//Sintaxis textBox... T mayusculua segudi del nombre  ejemplo Texto para poner notas = TNota
namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUser_Click(object sender, EventArgs e)
        {

        }

        private void UsuarioCont_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioIng.Text;
            string clave = UsuarioCont.Text;
            //Agregar que revise si esta bien el usuario, y si es asi que ingrese al mainaplicacion
            //si esta bien que haga lo siguiente
            this.Hide();
            MainAplicacion ss = new MainAplicacion();
            ss.Show();
        }
    }
}
