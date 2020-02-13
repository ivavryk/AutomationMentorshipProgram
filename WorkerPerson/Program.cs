using System;

namespace WorkerPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[]
            {
                new Worker("Inna", new DateTime(1999, 03,17), 1, 199),
                new Worker("Anna", new DateTime(2002, 05, 11), 2, 201),
                new Worker("Mira", new DateTime(1997, 02, 14), 3, 300),
                new Worker("Olena", new DateTime(1987, 12, 13), 4, 450),
            };

            Console.WriteLine("List of workers aged < 20:");
            foreach (Worker worker in workers)
                if (worker.Age() < 20)
                    worker.OutPut();

            foreach (Worker worker in workers)
                if (worker.Salary > 200)
                {
                    worker.SalaryIncrease();
                }

            Console.WriteLine("\nList of workers with updated salaries:");
            foreach (Worker worker in workers)
                worker.OutPut();

            Array.Sort(workers);

            Console.WriteLine("\nSorted list of workers:");
            foreach (Worker worker in workers)
                worker.OutPut();

            Console.WriteLine();
        }
    }
}
