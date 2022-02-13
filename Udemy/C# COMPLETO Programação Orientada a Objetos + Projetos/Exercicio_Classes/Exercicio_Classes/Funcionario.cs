using System.Globalization;

namespace Exercicio_Classes
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalBruto { get; set; }
        public double Imposto { get; set; }

        public Funcionario(string nome, double salBruto, double imposto)
        {
            Nome = nome;
            SalBruto = salBruto;
            Imposto = imposto;
        }    

        public double SalLiquido()
        {
            return SalBruto - Imposto;
        }

        public double AumentaSalario(double porcentagemAumento)
        {
            return porcentagemAumento / 100 * SalBruto + SalLiquido();
        }


   

    }
}
