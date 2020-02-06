using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Collections ***");

            Console.WriteLine("*** List ***");

            Workers.List();

            Console.WriteLine("*** Dictionary ***");

            Workers.Dictionary();

            Console.Read();
        }
    }

    public static class Workers
    {
        public static void List()
        {
            var workers = new List<Worker>
            {
                new Worker { Name = "Rick", Salary = 200 },
                new Worker { Name = "Inna", Salary = 300 },
                new Worker { Name = "Anna", Salary = 400 },
                new Worker { Name = "John", Salary = 500 },
                new Worker { Name = "Dina", Salary = 600 }
            };

            var workerToDelete = workers.FirstOrDefault(x => x.Name == "Inna");

            Console.WriteLine("List before deleting of a worker:");
            foreach (var worker in workers)
                Console.WriteLine($"Name: {worker.Name}. Salary: {worker.Salary} UAH.");

            workers.Remove(workerToDelete);

            Console.WriteLine("List after deleting of the worker:");
            foreach (var worker in workers)
                Console.WriteLine($"Name: {worker.Name}. Salary: {worker.Salary} UAH.");
        }

        public static void Dictionary()
        {
            var countriesUnordered = new Dictionary<byte, string>
            {
                {1, "Ukraine"},
                {3, "Spain"},
                {2, "Portugal"},
                {5, "Sweden"},
                {4, "Poland"}
            };

            var countriesOrdered = countriesUnordered.OrderBy(pair => pair.Key);

            Console.WriteLine("Ordered list of countries:");
            foreach (var country in countriesOrdered)
            {
                Console.WriteLine(country.Value);
            }
        }
    }

    public class Worker
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
