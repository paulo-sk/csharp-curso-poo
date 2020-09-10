using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n) ? ");
            string depositoInicial = Console.ReadLine();

            //Variaveis devem ser declaradas fora dos condicionais se tiver a inteção de usar depois;
            double deposito = 0;
            if (depositoInicial.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Entre o valor do depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }
            //se vc quisesse fazer a condição com 2 construtores no if-else, vc poderia Declarar a variavel de referencia no começo (Conta c1;)
            //E depois cosntruir o objeto c1 = new Conta (1,2) ou c1 = new Conta(1,2,3) de acordo com o seu condicional, mas dessa forma
            //que vc criou inicialmente esta melhor que o do prefessor, vc é foda.
            Conta c1 = new Conta(conta, nome, deposito);

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(c1);

            Console.Write("\nEntre com valor para deposito: ");
            //ao inves de declarar uma variavel e usar como argumento, vc pode mandar o argumento diretamente no metodo
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1);

            Console.Write("\nEntre com valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1);

            
        }
    }
}
