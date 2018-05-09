﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Sintaxis tomgar:(iniciales mayusculas) inicial primera palabra + segunda palabra, ejemplo: cerrar sesion = CSesion
//Sintaxis textBox... T mayusculua segudi del nombre  ejemplo Texto para poner notas = TNota
namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public event EventHandler<LogInEventArgs> OnLogIn;


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            //abrir ventana de registro
        }

        private void UsuarioCont_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string usuario = UsuarioIng.Text;
            string clave = UsuarioCont.Text;
            List<Users> usuarios = Metodos.DeserializarUsers();
            Users LogInUser = Metodos.Log_In(usuarios, usuario, clave);
            if (LogInUser == null)
            {
                MessageBox.Show("Error en contraseña o correo");
                Metodos.SerializarUsers(usuarios);
            }
            else
            {
                
                LogInEventArgs inicia = new LogInEventArgs();
                inicia.Usuario = LogInUser;
                OnLogIn(this, inicia);

                this.Hide();
                Metodos.SerializarUsers(usuarios);
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


    }
}