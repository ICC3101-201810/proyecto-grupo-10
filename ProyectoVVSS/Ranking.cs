using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoVVSS
{
    [Serializable]
    class Ranking
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
