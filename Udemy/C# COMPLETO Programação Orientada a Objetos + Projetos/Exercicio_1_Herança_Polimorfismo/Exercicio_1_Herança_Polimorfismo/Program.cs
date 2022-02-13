using System;
using System.Collections.Generic;
using Exercicio_1_Herança_Polimorfismo.Entities;
using System.Globalization;


namespace Exercicio_1_Herança_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int x = int.Parse(Console.ReadLine());

            for (int count = 1; count <= x; count++)
            {
                Console.WriteLine($"Product #{count} data: ");
                Console.Write("Common, user or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeProduct == 'c')
                {                  
                    products.Add(new Product(name, price));
                }
                else if (typeProduct == 'u')
                {               
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                }
                else
                {          
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));

                }              

            }
            Console.WriteLine("\n");
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }


        }
    }
}
