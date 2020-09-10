using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Listas_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entendendo metodos de lista

            List<string> nomes = new List<string>();

            //Metodo Add: Adiciona item à lista, sempre na ultima posicao
            nomes.Add("Luan");
            nomes.Add("pk");
            nomes.Add("Neymar");
            nomes.Add("Light");
            imprime(nomes);


            //Metodo Insert: adiciona item à lista em uma posicao especifica:
            //o primeiro argumento é a posicao em que o elemento sera colocado.
            nomes.Insert(2, "Messi");
            imprime(nomes);

            //Propriedade Count: assim como no vetor tem o metodo Length para saber o tamanho do mesmo, na lista tem o metodo Count.
            Console.WriteLine("Tamano da lista, com propriedade Count: "+ nomes.Count);
            Console.WriteLine();
            //Metodo Find: retorna a primeira ocorrencia na lista de alguma condicao especifica, por ex:
            //Se vc quer achar o primeiro elemento da lista que comece com a letra L (Luan), vc vai usar uma espressao Lambda:
            //espressao lambda é uma funcão anonima, exemplo de uso: 
            //(x => x[0] == 'L'), significa que eu quero o elemento x, tal que x na posicao 0 (A primeira letra) seja igual a 'L'
            string s = nomes.Find(x => x[0] == 'L');
            Console.WriteLine("Primeira ocorrencia da lista que começa com a letra L: "+ s);

            //Metodo FindLast: Mesma coisa do Find, mas retorna a ULTIMA ocorrencia da condiçao:
            string s2 = nomes.FindLast(x => x[0] == 'L');
            Console.WriteLine("Ultima ocorrencia da lista que começa com a letra L: " + s2);
            Console.WriteLine();

            //Metodo FindIndex: retorna o index do elemento da primeira ocorrencia (inteiro)
            int n = nomes.FindIndex(x => x[0] == 'L');
            Console.WriteLine("Index da primeira ocorrencia da lista que começa com a letra L: "+n );

            //Metodo FIndLastIndex:.....
            int n2 = nomes.FindLastIndex(x => x[0] == 'L');
            Console.WriteLine("Index da ultima ocorrencia da lista que começa com a letra L: " + n2);

            //Metodo FindAll: pega todos, nao so o primeiro e ultimo. É bom para filtrar ou copiar parte de lista
            //vc pode copiar para uma array de string também, por ex:
            List<string> nomes2 = nomes.FindAll(x => x[0] == 'L'); //pega TODAS as ocorrencias que começam com 'L'
            Console.WriteLine("\nTodas as ocorrencias que da lista que começam com L: ");
            imprime(nomes2);

            //Metodo RemoveAll: remove todas as ocorrencias:
            Console.WriteLine("\nRemove todas as ocorrencias que começa com 'L': ");
            nomes.RemoveAll(x => x[0] == 'L');
            imprime(nomes);

            //Metodo RemoveAt: remove elemento pelo index, como argumento, esse metodo so recebe o numero inteiro:
            Console.WriteLine("Remover elemento na posicao 2(messi): ");
            nomes.RemoveAt(1);
            imprime(nomes);

            //Metodo RemoveRange(2, 4): os parametros significa que, da posicao 2 em diante, eliminar 4 elementos.
            Console.WriteLine("Aumentando a lista para dar exemplo do metodo RemoveRange(): ");
            nomes.Insert(0, "Luan");
            nomes.Insert(2, "Messi");
            nomes.Add("Light");
            nomes.Add("Cr7");
            imprime(nomes);

            Console.WriteLine("Agora vamos eliminar, a partir da posicao 2, 3 elementos(messi, neymar e light): ");
            nomes.RemoveRange(2, 3);
            imprime(nomes);

            
        }

        static void imprime(List<string> nomes)
        {
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
                
            }
            Console.WriteLine("------------------------------");
        }
    }
}
