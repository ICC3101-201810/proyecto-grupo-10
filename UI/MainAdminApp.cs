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
    public partial class MainAdminApp : Form
    {
        public MainAdminApp()
        {
            InitializeComponent();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BRemoveUser_Click(object sender, EventArgs e)
        {
            string Mail = TMail.Text;
        }

        private void BRemoveStores_Click(object sender, EventArgs e)
        {
            string Local = CStore.SelectedItem.ToString();
        }

        private void BAddStores_Click(object sender, EventArgs e)
        {
            AddStore a = new AddStore();
            a.Show();
        }

        private void BReplaceAdmin_Click(object sender, EventArgs e)
        {
            ReplaceAdmin a = new ReplaceAdmin();
            a.Show();
        }

        private void MainAdminApp_Load(object sender, EventArgs e)
        {

        }
    }
}
