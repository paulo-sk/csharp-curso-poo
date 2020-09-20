using Contratos.Entities;
using Contratos.Entities.Enums;
using System;
using System.Globalization;


namespace Contratos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Department's name: ");
            string dpName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many contracts to this worker? ");
            int cont = int.Parse(Console.ReadLine());

            //depois de receber os dados, instaciar os objetos
            Department department = new Department(dpName);
            Worker worker = new Worker(name, level, baseSalary, department);

            for (int i = 1; i <= cont; i++)
            {
                Console.WriteLine($"\nEnter #{i} contract data: ");

                Console.Write("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contratc = new HourContract(date, valuePerHour, duration);
                worker.AddContrac(contratc);

            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string dateS = Console.ReadLine();
            int mm = int.Parse(dateS.Substring(0, 2)); //corta a string, começando do zero, pegando 2 caracteres (não é até a posiçao 2)
            int yy = int.Parse(dateS.Substring(3)); //corta a string, da posicao 3 em diante

            Console.WriteLine($"{worker}Income for {dateS}: {worker.Income(yy,mm).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
