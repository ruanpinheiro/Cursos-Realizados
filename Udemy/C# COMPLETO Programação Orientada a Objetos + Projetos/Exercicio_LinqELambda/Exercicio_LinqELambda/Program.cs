using System;
using System.IO;
using Exercicio_LinqELambda.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Exercicio_LinqELambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    string[] lines = sr.ReadLine().Split(',');
                    employees.Add(new Employee(lines[0], lines[1], double.Parse(lines[2], CultureInfo.InvariantCulture)));
                }
            }

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture) + ":");
            var x = employees.Where(s => s.Salary > salary).Select(e => e.Email).OrderBy(e => e);
            foreach (var i in x)
            {
                Console.WriteLine(i);
            }

            var y = employees.Where(n => n.Name[0] == 'M').Sum(s => s.Salary);       
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + y.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
