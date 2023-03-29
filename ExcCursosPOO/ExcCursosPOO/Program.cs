using System;

namespace ExcCursosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso bcc = new Curso("Ciências da Computação", 100);

            Disciplina introComp = new Disciplina("Introdução à Computação", bcc);
            Disciplina alg = new Disciplina("Algoritmos", bcc);
            Disciplina desenvWeb = new Disciplina("Desenvolvimento Web", bcc);

            Professor thyago = new Professor("Thyago Quintas", introComp);
            Professor thiago = new Professor("Thiago Claro", alg);
            Professor abenza = new Professor("Fabio Abenza", desenvWeb);

            Disciplina[] disciplinas = { introComp, alg, desenvWeb };
            Professor[] professores = { abenza, thyago, thiago };

            
        }
    }
}