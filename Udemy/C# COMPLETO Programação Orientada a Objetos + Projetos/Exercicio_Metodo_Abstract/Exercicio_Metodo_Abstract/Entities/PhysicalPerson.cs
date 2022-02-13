using System.Globalization;

namespace Exercicio_Metodo_Abstract.Entities
{
    class PhysicalPerson : Person
    {
        public double ExpendituresHealt { get; set; }

        public PhysicalPerson(string name, double annualIncome,double expendituresHealt)  : base (name, annualIncome)
        {
            ExpendituresHealt = expendituresHealt;
        }

        public override double Taxes()
        {
            double taxes = 0.0;
            
            if (AnnualIncome < 20000.00)
            {
                if (ExpendituresHealt > 0)
                {
                    taxes = (AnnualIncome * 0.15) - (ExpendituresHealt * 0.5);
                }
                else
                {
                    taxes = AnnualIncome * 0.15;
                }

            }

            if (AnnualIncome >= 20000.00)
            {
                if (ExpendituresHealt > 0)
                {
                    taxes = (AnnualIncome * 0.25) - (ExpendituresHealt * 0.5);
                }
                else
                {
                    taxes = AnnualIncome * 0.25;
                }

            }

            return taxes;
        }

        public override string ToString()
        {
            return Name + ": $ " + Taxes().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
