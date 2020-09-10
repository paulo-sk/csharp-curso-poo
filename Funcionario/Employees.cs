using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Funcionario
{
    class Employees
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Salario { get; set; }

        public void IncreaseSalary(double porcentagem)
        {
            Salario = Salario * (1 + porcentagem/100);
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
