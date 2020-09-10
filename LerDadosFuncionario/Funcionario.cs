using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Globalization;

namespace LerDadosFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto * (1 + porcentagem / 100);
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
