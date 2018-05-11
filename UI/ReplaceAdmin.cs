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
            bool hay_error = false;
            try
            {
                string OldMail = TOld.Text;
                string NewMail = TNew.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al reemplazar admin\n" + exc.Message, "Error");
                hay_error = true;
            }
            if (hay_error==false)
            {
                MessageBox.Show("Admin reemplazado con exito");
                this.Close();
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BAddAdmin_Click(object sender, EventArgs e)
        {
            bool hay_error = false;
            try
            {
                string nombre = TName.Text;
                string clave = TClave.Text;
                string mail = TMail.Text;
                string apellido = TApellido.Text;
                string rut = TRut.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al agregar admin\n" +exc.Message, "Error");
                hay_error = true;
            }
            if (hay_error==false)
            {
                string nombre = TName.Text;
                string clave = TClave.Text;
                string mail = TMail.Text;
                string apellido = TApellido.Text;
                string rut = TRut.Text;
                AdminApp nuevo = new AdminApp(nombre, apellido, mail, clave, rut, 0);
                List<AdminApp> admins = Metodos.DeserializarAdminsApp();
                admins.Add(nuevo);
                Metodos.SerializarAdminsApp(admins);
                MessageBox.Show("Admin agregado con exito!");
                this.Close();
            }
        }
    }
}
