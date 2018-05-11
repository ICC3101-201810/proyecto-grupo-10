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
            DateTime HOpening;
            DateTime HClosing;
            this.Hide();
            MainAdminLocal a = new MainAdminLocal();
            a.Show();
        }
    }
}
