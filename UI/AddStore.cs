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
            string Nombre = TName.Text;
            string Rut = TRut.Text;
            int HOpen = Convert.ToInt32(TOpening.Text);
            int HClose = Convert.ToInt32(TClosing.Text);

            this.Hide();
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
