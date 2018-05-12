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
            List<Local> locales = Metodos.DeserializarLocal();
            foreach (Local l in locales)
            {
                CLocal.Items.Add(l.GetName());
            }
            Metodos.SerializarLocal(locales);
        }
        public EventHandler<RankEventArgs> OnRanking;

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

        }

        private void BEnviar_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            try
            {
                Double Nota = Convert.ToDouble(TNota.Text);
                string Comentario = TComentario.Text;
                string lugar = CLocal.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Hay un campo vacio!", "Error");
                hay_error = true;
            }

            if (hay_error == false)
            {
                Double Nota = Convert.ToDouble(TNota.Text);
                string Comentario = TComentario.Text;
                string lugar = CLocal.SelectedItem.ToString();
                List<Local> locales = Metodos.DeserializarLocal();
                Local selected = Metodos.BuscaLocal(lugar, locales);
                Users aUser = AUser.UsuarioA;
                aUser.SetNota(selected, Nota, Comentario);
                Metodos.SerializarLocal(locales);
                MessageBox.Show("Nota Enviada a " + selected.GetName());
                this.Close();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
