using System;
using System.Collections.Generic;

namespace Exercicio_para_relembrar
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1, pessoa2;

            Console.WriteLine("Dados da primeira pessoas:");

       
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            pessoa1 = new Pessoa(name, idade);

            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            pessoa2 = new Pessoa(name, idade);

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Idade);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Idade);
            }




        }
    }
}
