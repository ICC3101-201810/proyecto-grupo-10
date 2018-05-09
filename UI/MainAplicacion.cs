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
    public partial class MainAplicacion : Form
    {
        public MainAplicacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ANota_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradesComm nn = new GradesComm();
            nn.Show();
        }

        private void VLocales_Click(object sender, EventArgs e)
        {
            List<Local> locales = Metodos.DeserializarLocal();
            foreach (Local lugar in locales)
            {
                MessageBox.Show(lugar.GetName());
            }
            Metodos.SerializarLocal(locales);
        }

        private void ASaldo_Click(object sender, EventArgs e)
        {
            
        }
    }
}