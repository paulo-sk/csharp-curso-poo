using System;

namespace MatrizFronteiras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a linha e coluna da matriz: ");
            string[] dimensaoS = Console.ReadLine().Split(' ');
            int l = int.Parse(dimensaoS[0]);
            int c = int.Parse(dimensaoS[1]);

            int[,] matriz = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');

                for (int y = 0; y < c; y++)
                {
                    matriz[i, y] = int.Parse(linha[y]);
                }

            }
            Console.Write("\nEntre o nuemro que se deseja veriricar as fronteireas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {

                for (int y = 0; y < c; y++)
                {
                    if (matriz[i, y] == n) {

                        
                        Console.WriteLine($"Position {i}, {y}: ");

                        if (InBounds((y - 1), matriz) == true)
                            Console.WriteLine($"Left: {matriz[i, y - 1]}");

                        if (InBounds((i - 1), matriz) == true)
                            Console.WriteLine($"Top: {matriz[i -1,y]}");

                        if (InBounds((y + 1), matriz) == true)
                            Console.WriteLine($"Rigth: {matriz[i,y + 1]}");

                        if (InBounds((i + 1), matriz) == true)
                            Console.WriteLine($"Down: {matriz[i + 1, y]}");

                        Console.WriteLine();
                    }

                  
                }
                //teste git
            }
        }

        // matriz.GetLenght(0) = tamanho das linhas,  matriz.GetLenght(1) = tamanho das colunas.
        static private bool InBounds(int index, int[,] matriz)
        {
            return (index >= 0) && index < matriz.GetLength(0) && index < matriz.GetLength(1);
        }
    }
}
