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

        public static AdminLocal adm_l;
        public static AdminLocal AdminLocalA
        {
            get { return adm_l; }
            set { adm_l = value; }
        }

        public static AdminApp adm_a;
        public static AdminApp AdminAppA
        {
            get { return adm_a; }
            set { adm_a = value; }
        }

    }
}
