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
    public partial class ReplaceAdmin : Form
    {
        public ReplaceAdmin()
        {
            InitializeComponent();
        }

        private void BReplace_Click(object sender, EventArgs e)
        {
            string OldMail = TOld.Text;
            string NewMail = TNew.Text;
            this.Hide();
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BAddAdmin_Click(object sender, EventArgs e)
        {
            string NewMail = TNew.Text;
            this.Hide();
        }
    }
}
