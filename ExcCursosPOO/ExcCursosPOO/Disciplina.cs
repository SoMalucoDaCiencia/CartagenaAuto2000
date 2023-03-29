using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcCursosPOO
{
    public class Disciplina 
    {
        public string nome;
        public Curso curso;
        public Disciplina(string nomeDisciplina, Curso cursoDisciplina) 
        {
            this.nome = nomeDisciplina;
            this.curso = cursoDisciplina;
        }
    }
}
