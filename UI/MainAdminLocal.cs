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
    public partial class MainAdminLocal : Form
    {
        public MainAdminLocal()
        {
            InitializeComponent();
            Bienvenida.Text += "Bienvenido " + AUser.AdminLocalA.GetName() + "\nSaldo disponible: $" + AUser.AdminLocalA.GetSaldo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainAdminLocal_Load(object sender, EventArgs e)
        {

        }
    }
}