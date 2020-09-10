using System;
using System.Globalization;

namespace Retangulo_A_P_D
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo();

            Console.WriteLine("Entre com a largura e a altura do retângulo: ");

            retangulo1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Area = {retangulo1.Area().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Perimetro = {retangulo1.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Diagonal = {retangulo1.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
