using System;
using System.Globalization;

namespace Calculadora3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            Calculadora.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Calculadora.Circunferencia(Calculadora.Raio);
            Calculadora.Volume(Calculadora.Raio);
            Calculadora.Imprime();
        }
    }
}
