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
            List<Local> locales = Metodos.DeserializarLocal();
            foreach (Local l in locales)
            {
                Clocales.Items.Add(l.GetName());
            }
            Metodos.SerializarLocal(locales);
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
                List<Local> lista = Metodos.DeserializarLocal();
                string nombre = TName.Text;
                string clave = TClave.Text;
                string mail = TMail.Text;
                string apellido = TApellido.Text;
                string rut = TRut.Text;
                string algo = Clocales.SelectedItem.ToString();
                Local algo2 = Metodos.BuscaLocal(algo, lista);
                AdminLocal nuevo = new AdminLocal(nombre, apellido, mail, clave, rut, 0, algo2);
                List<AdminLocal> admins = Metodos.DeserializarAdminsLocal();
                Metodos.SerializarLocal(lista);
                admins.Add(nuevo);
                Metodos.SerializarAdminsLocal(admins);
                MessageBox.Show("Admin agregado con exito!");
                this.Close();
            }
        }
    }
}
