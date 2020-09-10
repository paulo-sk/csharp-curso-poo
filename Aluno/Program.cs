using System;
using System.Globalization;
using System.Linq;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do aluno: ");
            for (int i = 0; i < aluno.Notas.Length; i++)
            {
                aluno.Notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = aluno.Notas.Sum();

            if (soma >= 60)
            {
                Console.WriteLine($"NOTA FINAL = {soma.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {soma.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO");
                
                Console.WriteLine($"FALTARAM {(60 - soma).ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
