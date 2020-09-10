using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Calculadora2
{
    class Calculadora
    {
        public double Raio;

        public double Circunferencia(double raio)
        {
            return 2 * Math.PI * Raio;
        }

        public double Volume(double raio)
        {
            return (4.0 / 3) * Math.PI * Math.Pow(raio, 3);
        }

        public void Imprime() {
            Console.WriteLine($"Circunferencia: {Circunferencia(this.Raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Volume(this.Raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Math.PI.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
