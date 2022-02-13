using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Exercicio_Metodo_Abstract.Entities
{
    abstract class Person
    {
        List<Person> list = new List<Person>();

        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
      
       }

        public abstract double Taxes();

       

    }

}
