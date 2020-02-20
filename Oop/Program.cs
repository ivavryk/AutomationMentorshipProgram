using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Tasks from comment #4 =====");

            Console.WriteLine("\n*** Task 1 ***");

            State state = new State();

            state.internalVar = 1;
            state.protectedInternalVar = 2;
            state.publicVar = 3;

            state.internalMethod();
            state.protectedInternalMethod();
            state.publicMethod();

            Console.WriteLine("\n*** Task 2 ***");

            Student student = new Student("Lena", 3, true);

            Console.WriteLine("\n*** Task 3 ***");

            TVSet tvset = new TVSet();

            Console.WriteLine($"Default channel - {tvset.CurrentChannel}");

            tvset.NextChannel();

            Console.WriteLine($"Next channel - {tvset.CurrentChannel}");

            tvset.SelectChannel(18);

            Console.WriteLine($"Selected channel - {tvset.CurrentChannel}");

            tvset.PrevChannel();

            Console.WriteLine($"Previous channel - {tvset.CurrentChannel}");

            Console.WriteLine("\n*** Task 4 ***");

            tvset.IncreaseSoundVolume();
            tvset.IncreaseSoundVolume();
            tvset.IncreaseSoundVolume();
            tvset.IncreaseSoundVolume();

            Console.WriteLine($"Increased volume - {tvset.CurrentSoundVolume}");

            tvset.DeceaseSoundVolume();
            tvset.DeceaseSoundVolume();

            Console.WriteLine($"Decreased volume - {tvset.CurrentSoundVolume}");

            Console.WriteLine("\n*** Task 5 ***");

            Circle circle = new Circle(5);

            circle.Display();

            Cylinder cylinder = new Cylinder(5, 10);

            cylinder.Display();

            Console.WriteLine("\n*** Task 6 ***");

            Item item = new Item();
            item.AddOne("item1");
            item.AddOne("item2");
            item.AddOne("item3");
            item.AddOne("item4");

            item.RemoveOne();
            item.RemoveOne();

            item.GetTotal();

            Console.WriteLine("\n*** Task 7 ***");

            InterfaceTest _obj = new InterfaceTest();
            _obj.Brain();
            _obj.TalkEnglish();
            _obj.Walk();

            Console.WriteLine("\n*** Task 8 ***");

            new Ukrainian().SayHallo();
            new American().SayHallo();

            Console.WriteLine("\n*** Task 9 ***");

            Cat cat = new Cat();
            cat.EatSomething(Cat.Food.Fish);
            cat.EatSomething(Cat.Food.Mouse);
            cat.ShowSatietyLevel();

            Console.ReadKey();
        }
    }

    // Task 1
    public class State
    {
        int defaultVar;
        private int privateVar;
        private protected int protectedPrivateVar;
        protected int protectedVar;
        internal int internalVar;
        protected internal int protectedInternalVar;
        public int publicVar;

        void defaultMethod() => Console.WriteLine($"defaultVar = {defaultVar}");
        private void privateMethod() => Console.WriteLine($"privateVar = {privateVar}");
        private protected void protectedPrivateMethod() => Console.WriteLine($"protectedPrivateVar = {protectedPrivateVar}");
        protected void protectedMethod() => Console.WriteLine($"protectedVar = {protectedVar}");
        internal void internalMethod() => Console.WriteLine($"internalVar = {internalVar}");
        protected internal void protectedInternalMethod() => Console.WriteLine($"protectedInternalVar = {protectedInternalVar}");
        public void publicMethod() => Console.WriteLine($"publicVar = {publicVar}");
    }

    // Task 2
    public class Student
    {
        public Student()
        {
        }

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, int course)
        {
            this.name = name;
            this.course = course;
        }

        public Student(string name, int course, bool hasScholarship)
        {
            this.name = name;
            this.course = course;
            this.hasScholarship = hasScholarship;
        }

        private string name;
        private int course;
        private bool hasScholarship;
    }

    // Task 3, 4
    public class TVSet
    {
        private static int firstChannel = 1;
        private static int lastChannel = 100;

        private static int minSoundVolume = 0;
        private static int maxSoundVolume = 100;

        public int CurrentChannel { get; set; } = firstChannel;

        public int CurrentSoundVolume { get; set; } = minSoundVolume;

        public void NextChannel()
        {
            CurrentChannel += 1;

            if (CurrentChannel > lastChannel)
                CurrentChannel = firstChannel;
        }

        public void PrevChannel()
        {
            CurrentChannel -= 1;

            if (CurrentChannel < firstChannel)
                CurrentChannel = lastChannel;
        }

        public void SelectChannel(int channel)
        {
            if (!(channel < firstChannel || channel > lastChannel))
                CurrentChannel = channel;
        }

        public void IncreaseSoundVolume()
        {
            if (CurrentSoundVolume < maxSoundVolume)
                CurrentSoundVolume += 1;
        }

        public void DeceaseSoundVolume()
        {
            if (CurrentSoundVolume > minSoundVolume)
                CurrentSoundVolume -= 1;
        }
    }

    // Task 5
    class Circle
    {
        public Circle()
        {
        }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get;
            set;
        }

        // Print a text string with the area.
        public virtual void Display()
        {
            Console.WriteLine($"Area = {Math.PI * Math.Pow(Radius, 2)}");
        }
    }

    class Cylinder : Circle
    {
        public Cylinder(int radius, int height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public int Height
        {
            get;
            set;
        }

        // Print a text string with the volume.
        public override void Display()
        {
            Console.WriteLine($"Volume = {Math.PI * Math.Pow(Radius, 2) * Height}");
        }
    }

    // Task 6
    class Item
    {
        private readonly LinkedList<string> _itemNames = new LinkedList<string> ();

        public void AddOne(string name)
        {
            this._itemNames.AddLast(name);

            Console.WriteLine("successfully created");
        }

        public void RemoveOne()
        {
            string itemToDelete = _itemNames.Last.Value;

            this._itemNames.RemoveLast();

            Console.WriteLine($"successfully deleted {itemToDelete}");
        }

        public void GetTotal()
        {
            Console.WriteLine($"total items quantity is {_itemNames.Count}");
        }
    }

    // Task 7
    interface IAnimals
    {
        void Walk()
        {
        }

        void Brain()
        {
        }

        void TalkEnglish()
        {
        }
    }
    class InterfaceTest : IAnimals
    {
        public string Name = "arpit";
        public void Walk() // here I have given implementation of the interface method 
        {
            Console.Write("Animals can walk\n");
        }
        public void Brain()// here I have given implementation of the interface method 
        {
            Console.Write("Animals also have a brain\n");
        }
        public void TalkEnglish()// here I have given implementation of the interface method 
        {
            Console.Write("Animals can't talk in english\n");
        }
    }

    // Task 8
    abstract class Human
    {
        private string Name { get; set; }

        public abstract void SayHallo();
    }

    class Ukrainian : Human
    {
        public override void SayHallo()
        {
            Console.WriteLine("Pryvit");
        }
    }

    class American : Human
    {
        public override void SayHallo()
        {
            Console.WriteLine("Hallo");
        }
    }

    // Task 9
    class Cat
    {
        private int SatietyLevel { get; set; }

        internal enum Food : byte
        {
            Fish = 20,
            Mouse = 15,
            Feed = 30
        }
        
        public void EatSomething(Food food)
        {
            SatietyLevel += (byte)food;
        }

        public void ShowSatietyLevel()
        {
            Console.WriteLine($"Satiety Level = {SatietyLevel}");
        }
    }
}

