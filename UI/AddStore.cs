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
    public partial class AddStore : Form
    {
        public AddStore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            DateTime hoy = DateTime.Now;
            try
            {
                string Nombre = TName.Text;
                string Rut = TRut.Text;
                string[] Opening = TOpening.Text.Split(':');
                string[] HClosing = TClosing.Text.Split(':');
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al agregar local\n" + exc.Message, "Error");
                hay_error = true;
            }
            if (hay_error==false)
            {
                string Nombre = TName.Text;
                string Rut = TRut.Text;

                string[] Opening = TOpening.Text.Split(':');
                int horaOpen = Convert.ToInt32(Opening[0]);
                int minOpen = Convert.ToInt32(Opening[1]);

                string[] HClosing = TClosing.Text.Split(':');
                int horaCLose = Convert.ToInt32(HClosing[0]);
                int minClose = Convert.ToInt32(HClosing[1]);

                DateTime newAbre = new DateTime(hoy.Year, hoy.Month, hoy.Day, horaOpen, minOpen, 0);
                DateTime newCierre = new DateTime(hoy.Year, hoy.Month, hoy.Day, horaCLose, minClose, 0);
                Local newLocal = new Local(Nombre, Rut, newAbre, newCierre);
                List<Local> locales = Metodos.DeserializarLocal();
                locales.Add(newLocal);
                MessageBox.Show("Horario de local cambiado con exito!");
                Metodos.SerializarLocal(locales);
                this.Close();

            }

        }

        private void BBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
