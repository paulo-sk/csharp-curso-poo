using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produto
{
    class Produto
    {
        private string Nome;
        private double Preco;
        private int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto() { }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProduto(int add)
        {
            Quantidade += add;
        }

        public void RemoverProduto(int rm)
        {
            Quantidade -= rm;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}
