using System;

namespace DiagonalNegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Retorna os valores da diagonal principal e quantidade de numeros negativos");
            Console.Write("Entre com o numero N da matriz: ");
            int n = int.Parse(Console.ReadLine());

            //virgulas definem quantas dimensoes tem a matriz
            int[,] matriz = new int[n, n];

            Console.WriteLine("Digite os valores da matriz abaixo, linha por linha, separados por espaco");
            for (int i = 0; i < n; i++) {

                //vai sepapar os valores por espaço, e criar um vetor do mesmo tamanho da quantidade de espaco
                string[] valoresLinha = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {

                    matriz[i, j] = int.Parse(valoresLinha[j]);
                }
            }
            int negativos = 0;
            Console.WriteLine("\nDiagonal Secundaria:");
            for (int i = 0, j = n-1 ; i < n ; i++, j--)
            {
                Console.Write($"{matriz[i, j]} ");

            }

            Console.WriteLine($"\nQuantidade de numeros negativos: {negativos}");

        }
    }
}
