using System;
using System.Globalization;

namespace Calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calcularaio = new Calculadora();
            Console.Write("Entre com o valor do raio: ");
            calcularaio.Raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            calcularaio.Circunferencia(calcularaio.Raio);
            calcularaio.Volume(calcularaio.Raio);
            calcularaio.Imprime();
        }
    }
}
