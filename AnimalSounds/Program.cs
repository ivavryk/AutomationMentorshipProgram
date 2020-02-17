using System;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            ISound[] animalSounds = {new Cat(), new Dog()};

            foreach (ISound animalSound in animalSounds)
                animalSound.Sound();

            Console.ReadKey();
        }
    }

    interface ISound
    {
        void Sound();
    }

    class Cat : ISound
    {
        private string name;
        private string colour;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Colour
        {
            get => colour;
            set => colour = value;
        }

        public void Sound()
        {
            Console.WriteLine("M'yau");
        }
    }

    class Dog : ISound
    {
        private string name;
        private string colour;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Colour
        {
            get => colour;
            set => colour = value;
        }

        public void Sound()
        {
            Console.WriteLine("Gau");
        }
    }
}
