using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }

        public double Saldo { get; private set; }

       
        public Conta(int numeroConta, string nome, double depositoInicial)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= (saque + 5);
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}," +
                $" Titular: {Nome}," +
                $" Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
