using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerPerson
{
    class Worker : Person, IComparable <Worker>
    {
        public Worker(string name, DateTime birthDate, int workplace, int salary) : base(name, birthDate)
        {
            _workplace = workplace;
            _salary = salary;
        }

        private int _workplace;
        private int _salary;

        public int Workplace
        {
            get => _workplace;
            set => _workplace = value;
        }

        public int Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public void OutPut()
        {
            Console.WriteLine($"Name: {Name}, Birth date: {BirthDate}, Workplace: {Workplace}, Salary: {Salary}.");
        }

        public void SalaryIncrease()
        {
            Salary += Age();
        }

        public int CompareTo(Worker other)
        {
            return (String.Compare(this.Name, other.Name, StringComparison.Ordinal));
        }
    }
}
