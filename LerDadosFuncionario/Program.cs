using System;
using System.Globalization;

namespace LerDadosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();

            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            func1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //imprime dados
            Console.WriteLine($"\nFuncionario: {func1}");

            
            Console.Write("\nDigite a porcentagem para aumentar o sálario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func1.AumentarSalario(porcentagem);

            //imprime novamente dados atualizados
            Console.WriteLine($"\nDados atualizados: {func1}");
        }
    }
}
