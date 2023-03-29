using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcCursosPOO
{
    public class Aluno 
    {
        public string nome;
        public Disciplina disciplina;
        public Curso curso;
        public int qtdAlunos;
        public Aluno(string nomeAluno, Disciplina disciplinaAluno, Curso cursoAluno) 
        {
            this.nome = nomeAluno;
            this.disciplina = disciplinaAluno;
            this.curso = cursoAluno;
        }
    }
}
