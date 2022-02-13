using System;
using System.Globalization;
using Exercicio_1___Enumeracao_e_Composicao.Entities.Enums;
using Exercicio_1___Enumeracao_e_Composicao.Entities;
using System.Collections.Generic;

namespace Exercicio_1___Enumeracao_e_Composicao
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter cliente data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth data (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new(name, email, birth);
            Order order = new(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int x = int.Parse(Console.ReadLine());           

            for (int y = 1; y <= x; y++)
            {
                Console.WriteLine($"Enter #{y} item data");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Product product = new (nameProduct, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new(productQuantity, productPrice, product);           
                order.AddItem(orderItem);
            }

            Console.WriteLine("\n");
            Console.WriteLine(order);

            
        }
    }
}
