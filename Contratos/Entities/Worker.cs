using Contratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Contratos.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContrac(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContrac(HourContract contract)
        {

            Contracts.Remove(contract);
        }

        public double Income(int yy, int mm)
        {
            double income = BaseSalary;
            foreach (HourContract contrac in Contracts) {

                if (contrac.Date.Year == yy && contrac.Date.Month == mm)
                    income += contrac.TotalValue();
            }
            return income;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Department: {Department.Name}\n";
        }
    }
}
