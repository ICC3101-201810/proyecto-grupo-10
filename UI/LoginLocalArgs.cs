using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class LoginLocalEventArgs :EventArgs
    {
        public AdminLocal admin { get; set; }
    }
}
