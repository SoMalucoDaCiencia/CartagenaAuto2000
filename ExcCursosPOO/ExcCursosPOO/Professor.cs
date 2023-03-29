using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcCursosPOO
{
    public class Professor 
    {
        public string nome;
        public Disciplina disciplina;
        public Professor(string nomeProf, Disciplina disciplinaProf)
        {
            this.nome = nomeProf;
            this.disciplina = disciplinaProf;
        }
    }
}
