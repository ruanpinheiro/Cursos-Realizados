using System.Globalization;

namespace Exercicio_Metodo_Abstract.Entities
{
    class LegalPerson : Person
    {
        public int Employees { get; set; }

        public LegalPerson(string name, double annualIncome, int employees) : base (name, annualIncome)
        {
            Employees = employees;
        }

        public override double Taxes()
        {
            double taxes = 0.0;
         
                if (Employees <= 10)
                {
                    taxes = (AnnualIncome * 0.16);
                }
                else
                {
                    taxes = (AnnualIncome * 0.14);

                }
                      
            return taxes; ;
        }

        public override string ToString()
        {
            return Name + ": $ " + Taxes().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
