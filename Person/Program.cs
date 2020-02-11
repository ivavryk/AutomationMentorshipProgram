using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Anna", new DateTime(2000, 12, 22));
            Person p2 = new Person("Mira", new DateTime(1999, 08, 14));

            p1.Name = "Inna";
            p1.BirthDate = new DateTime(2001, 07, 15);

            Console.WriteLine($"Age of {p1.Name} is {p1.Age()}");
            Console.WriteLine($"Age of {p2.Name} is {p2.Age()}");

            Console.ReadKey();
        }
    }

    class Person
    {
        public Person(string name, DateTime birthDate)
        {
            _name = name;
            _birthDate = birthDate;
        }


        private string _name;
        private DateTime _birthDate;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }

        public int Age()
        {
            DateTime today = DateTime.Today;

            int age = today.Year - BirthDate.Year;
            if (BirthDate > today.AddYears(-age)) age--;

            return age;
        }
    }
}
