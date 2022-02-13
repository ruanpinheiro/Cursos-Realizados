using System;
using Exercicio_Metodo_Abstract.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Metodo_Abstract
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<Person> list = new List<Person>();
            double sum = 0.0;


            Console.Write("Enter the number of tax payers: ");
            int var = int.Parse(Console.ReadLine());


            for (int x = 1; x <= var; x++)
            {
                Console.WriteLine($"Tax payer #{x} data:");
                Console.Write("Individual or company (i/c)? ");
                char typePerson = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(typePerson == 'i')
                {
                    Console.Write("Healt expenditures: ");
                    double healtExpendidures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PhysicalPerson(name, annualIncome, healtExpendidures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new LegalPerson(name, annualIncome, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            foreach (Person person in list)
            {
                Console.WriteLine(person.ToString());
            }

            Console.WriteLine();

            foreach (Person person in list)
            {              
                sum += person.Taxes();
            }

            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
