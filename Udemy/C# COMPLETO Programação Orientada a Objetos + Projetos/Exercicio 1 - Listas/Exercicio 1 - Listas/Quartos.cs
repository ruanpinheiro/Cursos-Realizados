using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1___Listas
{
    class Quartos
    {
        public string NomeAluno { get; set; }
        public string EmailAluno { get; set; }
        public int Quarto { get; set; }

        public Quartos(string nomeAluno, string emailAluno, int quarto)
        {
            NomeAluno = nomeAluno;
            EmailAluno = emailAluno;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Quarto + ":" + NomeAluno + "," + EmailAluno;
        }
    }
}
