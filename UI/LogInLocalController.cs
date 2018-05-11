using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class LogInLocalController
    {
        Form1 login;
        AdminLocal ActiveAdmin = null;
        public LogInLocalController(Form1 menu)
        {
            login = menu;
            this.login.OnLogInL += Menu_LogIn;
        }
        private void Menu_LogIn(object sender, LoginLocalEventArgs e)
        {
            ActiveAdmin = e.admin;
            MainAdminLocal a = new MainAdminLocal();
            a.Show();
            login.Enabled = false;
        }
    }
}
