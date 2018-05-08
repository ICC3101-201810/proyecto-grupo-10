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
    public partial class GradesComm : Form
    {
        public GradesComm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAplicacion ss = new MainAplicacion();
            ss.Show();
        }

        private void BEnviar_Click(object sender, EventArgs e)
        {
            int Nota = Int32.Parse(TNota.Text);
            string Comentario = TComentario.Text;

        }
    }
}
