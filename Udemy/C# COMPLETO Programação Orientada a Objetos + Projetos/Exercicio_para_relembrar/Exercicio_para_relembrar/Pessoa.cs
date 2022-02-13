using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_para_relembrar
{
    class Pessoa
    {
        public string Name { get; private set; }
        public int Idade { get; private set; }

        public Pessoa(string name, int idade)
        {
            Name = name;
            Idade = idade;
        }
    }
}
