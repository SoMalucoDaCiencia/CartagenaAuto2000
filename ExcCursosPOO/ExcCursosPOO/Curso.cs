using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcCursosPOO
{
    public class Curso
    {
        public string nome;
        public int alunos;
        public Curso(string nomeCurso, int qtdAlunos) 
        {
            this.nome = nomeCurso;
            this.alunos = qtdAlunos;
        }
    }
}
