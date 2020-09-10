using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Calculadora3
{
    static class Calculadora
    {
        static public double Raio;
        static public double Circunferencia(double raio)
        {
            return 2.0 * Math.PI * raio;
        }
        static public double Volume(double raio)
        {
            return (4.0 / 3) * Math.PI * Math.Pow(raio, 3);
        }

        static public void Imprime()
        {
            Console.WriteLine($"Cirunferencia: {Circunferencia(Calculadora.Raio).ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Volume(Calculadora.Raio).ToString("f2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Math.PI.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}
