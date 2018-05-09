using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    static class AUser
    {
        public static Users Usuario;
        public static Users UsuarioA
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

    }
}
