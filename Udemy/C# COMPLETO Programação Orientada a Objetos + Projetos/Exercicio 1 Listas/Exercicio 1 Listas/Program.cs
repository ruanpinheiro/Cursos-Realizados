using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_1_Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("How many employees will be registered? ");
            int var = int.Parse(Console.ReadLine());

            List<Employee> employees = new();

            for (int x = 1; x <= var; x++ )
            {
                Console.WriteLine("Employee #" + x + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine("\n");
                               
                
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == idIncrease);
            if (emp != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
           else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Update list of employess: ");
                foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }



        }
    }
}