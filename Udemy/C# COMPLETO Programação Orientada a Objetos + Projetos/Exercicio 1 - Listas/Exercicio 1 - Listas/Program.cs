using System;

namespace Exercicio_1___Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            Quartos[] quartos = new Quartos[10];

            Console.Write("How many room will be rented? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            for (int var = 1; var <= qtdQuartos; var++)
            {
                Console.WriteLine("Rent #" + var + ":");
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Room:");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                quartos[quarto] = new (name, email, quarto);
            }

            Console.WriteLine("Busy rooms");
            for (int var = 0; var < 10; var++)
            {
                if (quartos[var] != null)
                {
                    Console.WriteLine(quartos[var].ToString());
                }
            }

        }
    }
}
