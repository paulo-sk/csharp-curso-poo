using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static double PI = Math.PI;
       
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {PI.ToString("f2", CultureInfo.InvariantCulture)}");
        }

        static double Circunferencia(double raio) {
            return 2 * PI * raio;
        }

        static double Volume(double raio) {
            return (4.0 / 3) * PI * Math.Pow(raio,3);
        }
    }
}
