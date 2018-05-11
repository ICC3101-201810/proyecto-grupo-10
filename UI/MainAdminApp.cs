﻿using System;
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
            Application.Exit();
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
            if (hay_error==false)
            {

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

            }
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
