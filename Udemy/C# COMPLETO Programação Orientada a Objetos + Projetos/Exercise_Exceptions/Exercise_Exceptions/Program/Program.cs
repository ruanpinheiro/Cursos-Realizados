using System;
using System.Globalization;
using System.Collections.Generic;
using Exercise_Exceptions_DomainExceptions.Entities;
using Exercise_Exceptions_DomainExceptions.Exceptions;

namespace Exercise_Exceptions_DomainExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int numberAccount = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = (new Account(numberAccount, holder, initialBalance, withDrawLimit));         


            try
            {
                Console.WriteLine("\n");
                Console.Write("Enter amount for withdraw: ");
                double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(withDraw);

                Console.WriteLine(account.ToString());
            }

            catch (Exception e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            
            
        }
    }
}
