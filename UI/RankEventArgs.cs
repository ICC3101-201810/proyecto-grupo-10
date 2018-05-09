using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class RankEventArgs : EventArgs
    {
        public Users Usuario { get; set; }
        public Local Lugar { get; set; }
        public double Nota { get; set; }
        public string Comment { get; set; }
    }
    class RankController
    {
        GradesComm ventana;
        Users ActiveUser = null;
        public RankController(GradesComm vent)
        {
            vent = ventana;
            this.ventana.OnRanking += EnviaNota;
        }
        private void EnviaNota(object sender, RankEventArgs e)
        {
            ActiveUser = e.Usuario;
            ActiveUser.SetNota(e.Lugar, e.Nota, e.Comment);
            MainAplicacion menu = new MainAplicacion();
            menu.Show();
            ventana.Enabled = false;
        }
    }
}
