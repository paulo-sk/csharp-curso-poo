using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instanciado com as variaveis acima
            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine($"\nDados do produto: {produto}");

            Console.Write("\nDigite um numero de produtos a serem adicionado: ");
            int add = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(add);

            Console.WriteLine($"\nDados atualizados: {produto}");

            Console.Write("\nDigite um numero de produtos a serem removidos: ");
            int rem = int.Parse(Console.ReadLine());
            produto.RemoverProduto(rem);
            Console.WriteLine($"\nDados atualizados: {produto}");
            

        }
    }
}
