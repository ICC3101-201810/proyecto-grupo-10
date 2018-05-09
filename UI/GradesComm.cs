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
            MainAplicacion ss = new MainAplicacion();
            ss.Show();
        }

        private void BEnviar_Click(object sender, EventArgs e)
        {
            int Nota = Int32.Parse(TNota.Text);
            string Comentario = TComentario.Text;
            string lugar = CLocal.SelectedText;
            List<Local> locales = Metodos.DeserializarLocal();
            Local selected = Metodos.BuscaLocal(lugar, locales);
            Metodos.SerializarLocal(locales);

            RankEventArgs args_nota = new RankEventArgs();
            args_nota.Lugar = selected;
            args_nota.Nota = Nota;
            args_nota.Comment = Comentario;

            OnRanking(this, args_nota);
            

            this.Hide();
            MainAplicacion ss = new MainAplicacion();
            ss.Show();

            //este boton recibe nota , comentario y local; hay que meterlos a la app.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
