using System;
using System.Globalization;
namespace Alguel
{
    class Program
    {
        static void Main(string[] args)
        {

            Quarto[] quarto = new Quarto[10];

            Console.Write("How many roons will be rented? ");
            int rent = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            for (int i = 0; i < rent; i++)
            {
                Console.WriteLine($"\nRent #{i+1}:");

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                quarto[room] = new Quarto { Nome = nome, Email = email };
            }

            Console.WriteLine("\nBusy rooms: ");
            for (int i = 0; i < quarto.Length; i++)
            {
                if (quarto[i] != null)
                    Console.WriteLine($"{i}: {quarto[i]}");
            }
        }
    }
}
