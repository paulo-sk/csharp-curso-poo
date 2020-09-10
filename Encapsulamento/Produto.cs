using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;


        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //isso é uma propertie, assim, na metodo main, posso setar o nome do atributo _nome, chamando a propriedade Nome, como se fosse
        //um atributo, p.Nome = "dawfawf"; Assim fica mais intuitivo, pois propriedade É UM METODO, mas parece um atributo na hora de chamar (get)
        //ou setar (set), portanto, no c#, não usamos o get e set como no java.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) //é obrigatorio o uso do value, que é o valor que o metodo recebe do usuario.
                    _nome = value;
            }
        }


        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }

        public void AdicionarProduto(int add)
        {
            _quantidade += add;
        }

        public void RemoverProduto(int rm)
        {
            _quantidade -= rm;
        }

        public override string ToString()
        {
            return $"{_nome}, $ {_preco}, {_quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";

        }

    }

}
