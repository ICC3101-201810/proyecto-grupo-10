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
    public partial class SetSales : Form
    {
        public SetSales()
        {
            InitializeComponent();
        }

        private void CLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CProducto.ResetText();
            List<Local> locales = Metodos.DeserializarLocal();
            string elige_local = CLocal.SelectedItem.ToString();
            Local Lugar = Metodos.BuscaLocal(elige_local, locales);
            List<Producto> Opciones = Lugar.GetMenu();
            foreach (Producto item in Opciones)
            {
                CProducto.Items.Add(item.GetNombre());
            }
            Metodos.SerializarLocal(locales);
        }

        private void BSale_Click(object sender, EventArgs e)
        {
            int precio_oferta = Convert.ToInt32(TPrecio.Text);
            AdminLocal admin = AUser.AdminLocalA;

        }
    }
}
