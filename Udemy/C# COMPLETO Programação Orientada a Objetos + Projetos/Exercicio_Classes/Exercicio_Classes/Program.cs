using System;
using System.Globalization;

namespace Exercicio_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Slário bruto: ");
            double salBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario f1 = new Funcionario(nome, salBruto, imposto);

            Console.WriteLine("Funcionário: " + f1.Nome + ", $ " + f1.SalLiquido().ToString("f2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentaSalario(porcentagem);

            Console.WriteLine("Funcionário: " + f1.Nome + ", $ " + f1.AumentaSalario(porcentagem).ToString("f2", CultureInfo.InvariantCulture));


        }
    }
}
