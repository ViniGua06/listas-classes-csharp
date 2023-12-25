using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

        public void MatricularAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(int codigo)
        {
            Pessoa pessoa = Alunos.Find(a => a.Codigo == codigo);

            if (pessoa != null)
            {
                Alunos.Remove(pessoa);
                Console.WriteLine("Aluno removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Codigo inválido!");
            }
        }



        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine("Aluno " + aluno.Codigo + ": Nome: " + aluno.Nome + ", idade: " + aluno.Idade);
            }
        }
    }
}