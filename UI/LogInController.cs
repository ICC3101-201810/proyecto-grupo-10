using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class LogInController
    {
        Form1 form_login;
        Users ActiveUser = null;
        public LogInController(Form1 form)
        {
            form_login = form;
            this.form_login.OnLogIn += Menu_LogIn;
            
        }
        private void Menu_LogIn(object sender, LogInEventArgs e )
        {
            ActiveUser = e.Usuario;
            MainAplicacion menu = new MainAplicacion();
            menu.Show();
            form_login.Enabled = false;
        }
    }
}
