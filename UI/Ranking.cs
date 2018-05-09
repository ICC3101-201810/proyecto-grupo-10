using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    [Serializable]
    public class Ranking
    {
        Local local;
        double nota;
        string comentario;
        public Ranking(Local lugar, double Nota, string Comment)
        {
            local = lugar;
            nota = Nota;
            comentario = Comment;
        }
    }
}
