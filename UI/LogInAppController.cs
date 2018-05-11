using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class LogInAppController
    {
        Form1 login_form;
        AdminApp admin = null;
        public LogInAppController(Form1 form)
        {
            login_form = form;
            this.login_form.OnLogInA += Menu_Login;
        }
        private void Menu_Login(object sender, LogInAppEventArgs e)
        {
            admin = e.adminApp;
            MainAdminApp menu = new MainAdminApp();
            menu.Show();
            login_form.Enabled = false;

        }
    }
}
