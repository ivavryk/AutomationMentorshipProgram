using System;

namespace WorkerPerson
{
    class Person
    {
        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }


        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age()
        {
            DateTime today = DateTime.Today;

            int age = today.Year - BirthDate.Year;
            if (BirthDate > today.AddYears(-age)) age--;

            return age;
        }
    }
}