using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> empregados = new List<Employees>();

            Console.Write("How many employees will be registred? ");
            int registro = int.Parse(Console.ReadLine());

            for (int i = 0; i < registro; i++)
            {
                Console.WriteLine($"\nEmployess #{i + 1}");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                //se id for igual, decrementa o laço e "continua" voltando na mesma posiçao
                if (TestId(empregados, id) == false)
                {
                    i -= 1;
                    continue;
                }
                    
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                empregados.Add(new Employees() { Id = id, Nome = name, Salario = salario });

            }

            Console.Write("\nEnter the employee id tha will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());
            //ache o index na lista empregrados, tal que este empregado tenha o mesmo id que o usuario digitou para aumentar o salario
            Employees empregadoAumento = empregados.Find(x => x.Id == idIncrease);

            //essa nova variavel do tipo Employees aponta para o mesmo endereço de memoria, onde contem o objeto com aquele id
            //dessa forma, existem 2 apontadores para aquele objeto, que é essa nova variavel empregadoAumento, e o empregados[index] da lista

            /*codigo antigo:
             * eu tinha achado o index do empregado[index] tal qual tinha o id requerido, salvei esse valor em uma nova variavel:
             * int indexIncrease = empregados.FindIdex(x => x.Id == idIncrease);
             * 
             * e dos testei em um for para ver se esse indexIncrease não era negativo (quando negativo(-1) significa que o idIncrease nao estava na lista
             * 
             * usei empregados[indexIncrease].IncreaseSalary(porcentagem) para aumentar o salaraio.
             */

            if (empregadoAumento == null)
            {
                Console.WriteLine("This id does not exist!");
            }

            else {
                Console.Write("Enter the porcentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                empregadoAumento.IncreaseSalary(porcentagem);
                
                //Agora, antes de imprimir, vamos ordenar a lista pelo ID.
                empregados = empregados.OrderBy(x => x.Id).ToList();

            }

            Console.WriteLine("\nUpdated list of emplyees:");
            foreach (Employees empregado in empregados)
                Console.WriteLine(empregado);


        }

        static bool TestId(List<Employees> id, int idEnter)
        {
            //variavel de test
            bool test = true;
            //for para testar todos os ids entre si;
            for (int y = 0; y < id.Count; y++)
            {
                if (idEnter == id[y].Id)
                {
                    test = false;
                    Console.WriteLine("Este ID ja esta em registro!");
                    break;
                }
            }
            return test;
        }

            

        
    }
}
