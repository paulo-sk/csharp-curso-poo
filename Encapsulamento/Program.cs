using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV",500.00,15);

            p.Nome = "t";

            Console.WriteLine(p);
        }
    }
}
