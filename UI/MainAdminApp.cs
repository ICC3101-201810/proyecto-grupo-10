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
            CStore.Items.Clear();
            CMail.Items.Clear();
            List<Users> usuarios = Metodos.DeserializarUsers();
            List<Local> locales = Metodos.DeserializarLocal();
            foreach (Local item in locales)
            {
                CStore.Items.Add(item.GetName());
            }
            foreach (Users item in usuarios)
            {
                CMail.Items.Add(item.GetMail());
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BRemoveUser_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            try
            {
                string mail = CMail.SelectedItem.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al remover usuario!\n" + exc.Message, "Error");
                hay_error = true;
            }
            if (hay_error == false)
            {
                string mail = CMail.SelectedItem.ToString();
                List<Users> usuarios = Metodos.DeserializarUsers();
                AdminApp adminActivo = AUser.AdminAppA;
                adminActivo.QuitarUser(usuarios, mail);
                MessageBox.Show("Usuario removido con exito!");
                CMail.Items.Clear();
                foreach (Users item in usuarios)
                {
                    CMail.Items.Add(item.GetMail());
                }
                Metodos.SerializarUsers(usuarios);


            }
        }

        private void BRemoveStores_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            try
            {
                string Local = CStore.SelectedItem.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al remover local!\n" + exc.Message, "Error");
                hay_error = true;
            }
            if (hay_error==false)
            {
                string Local = CStore.SelectedItem.ToString();
                List<Local> locales = Metodos.DeserializarLocal();
                Local ARemover = Metodos.BuscaLocal(Local, locales);
                AdminApp adminActivo = AUser.AdminAppA;
                adminActivo.QuitarLocal(locales, Local);
                MessageBox.Show("Local removido con exito!");
                CStore.Items.Clear();
                foreach (Local item in locales)
                {
                    CStore.Items.Add(item.GetName());
                }
                Metodos.SerializarLocal(locales);


            }
        }

        private void BAddStores_Click(object sender, EventArgs e)
        {
            AddStore a = new AddStore();
            a.Show();
            this.Close();
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
