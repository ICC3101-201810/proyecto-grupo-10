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
    public partial class Hours : Form
    {
        public Hours()
        {
            InitializeComponent();
        }

        private void BListo_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            bool hay_error = false;
            try
            {
                int HOpening = Convert.ToInt32(TAbrir.Text);
                int HClosing = Convert.ToInt32(TCerrar.Text);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error al cambiar horario de local\n" + exc.Message, "Error");
                hay_error = true;
            }
            if (hay_error==false)
            {
                string[] Opening =TAbrir.Text.Split(':');
                int horaOpen = Convert.ToInt32(Opening[0]);
                int minOpen = Convert.ToInt32(Opening[1]);

                string[] HClosing = TCerrar.Text.Split(':');
                int horaCLose = Convert.ToInt32(HClosing[0]);
                int minClose = Convert.ToInt32(HClosing[1]);

                DateTime newAbre = new DateTime(hoy.Year, hoy.Month, hoy.Day, horaOpen, minOpen, 0);
                DateTime newCierre = new DateTime(hoy.Year, hoy.Month, hoy.Day, horaCLose, minClose, 0);

                List<Local> locales = Metodos.DeserializarLocal();
                AdminLocal admin = AUser.AdminLocalA;
                Local lugar = Metodos.BuscaLocal(admin.GetLocal().GetName(), locales);
                lugar.horario.Clear();
                lugar.horario[0] = newAbre;
                lugar.horario[1] = newCierre;

                MessageBox.Show("Horario de local cambiado con exito!");
                this.Close();
                MainAdminLocal a = new MainAdminLocal();
                a.Show();
            }


        }

        private void BBack_Click(object sender, EventArgs e)
        {

        }
    }
}
