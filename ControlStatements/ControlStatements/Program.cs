using System;

namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Tasks for Conrtol Statements ***");
            Console.WriteLine();
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            Task3();
            Console.WriteLine();
            Task4();
            Console.WriteLine();
            Task5();
            Console.WriteLine();
            Task6();
            Console.WriteLine();
            Task7();
            Console.WriteLine();
            Task8();
            Console.WriteLine();
            Task9();
            Console.WriteLine();
            Task10();

            Console.ReadLine();
        }

        private static void Task1()
        {
            Console.WriteLine("--- Task 1 ---");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('8');
                }
                Console.WriteLine();
            }
        }

        private static void Task2()
        {
            Console.WriteLine("--- Task 2 ---");

            Console.WriteLine("Horizontal line:");
            for (int i = 0; i < 10; i++)
                Console.Write('8');

            Console.WriteLine();

            Console.WriteLine("Vertical line:");
            for (int i = 0; i < 10; i++)
                Console.WriteLine('8');
        }

        private static void Task3()
        {
            Console.WriteLine("--- Task 3 ---");

            int minValue = 2;
            int maxValue = 20;
            int sizeOfArray = 0;
            int[] myArray;

            // Define the size of the array.
            for (int valueOfArrayElement = minValue; valueOfArrayElement <= maxValue; valueOfArrayElement++)
                if (valueOfArrayElement % 2 == 0)
                    sizeOfArray++;

            myArray = new int[sizeOfArray];

            // Fill the array.
            for (int indexOfArrayElement = 0; indexOfArrayElement < sizeOfArray; indexOfArrayElement++)
            {
                for (int valueOfArrayElement = minValue; valueOfArrayElement <= maxValue; valueOfArrayElement++)
                {
                    if (valueOfArrayElement % 2 == 0)
                    {
                        myArray[indexOfArrayElement] = valueOfArrayElement;
                        minValue = myArray[indexOfArrayElement] + 1;
                        break;
                    }
                }
            }

            Console.WriteLine("Row:");
            foreach (int element in myArray)
                Console.Write(element + " ");

            Console.WriteLine();

            Console.WriteLine("Column:");
            foreach (int element in myArray)
                Console.WriteLine(element);
        }
        private static void Task4()
        {
            Console.WriteLine("--- Task 4 ---");

            int minValue = 1;
            int maxValue = 99;
            int sizeOfArray = 0;
            int[] myArray;

            // Define the size of the array.
            for (int valueOfArrayElement = minValue; valueOfArrayElement <= maxValue; valueOfArrayElement++)
                if (valueOfArrayElement % 2 != 0)
                    sizeOfArray++;

            myArray = new int[sizeOfArray];

            // Fill the array.
            for (int indexOfArrayElement = 0; indexOfArrayElement < sizeOfArray; indexOfArrayElement++)
            {
                for (int valueOfArrayElement = minValue; valueOfArrayElement <= maxValue; valueOfArrayElement++)
                {
                    if (valueOfArrayElement % 2 != 0)
                    {
                        myArray[indexOfArrayElement] = valueOfArrayElement;
                        minValue = myArray[indexOfArrayElement] + 1;
                        break;
                    }
                }
            }

            Console.WriteLine("Direct order:");
            foreach (int element in myArray)
                Console.Write(element + " ");

            Console.WriteLine();

            Console.WriteLine("Reverse order:");
            for (int index = myArray.Length - 1; index >= 0; index--)
                Console.Write(myArray[index] + " ");
        }
        private static void Task5()
        {
            Console.WriteLine("--- Task 5 ---");

            byte dayNumber;
            string dayValue;
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("Enter value 1 to 7: ");

            while (!(byte.TryParse(Console.ReadLine(), out dayNumber) && dayNumber >= 1 && dayNumber <= 7))
                Console.WriteLine("Incorrect value entered. Please enter value 1 to 7: ");

            switch (dayNumber)
            {
                case 1:
                    {
                        dayValue = day[0];
                        break;
                    }
                case 2:
                    {
                        dayValue = day[1];
                        break;
                    }
                case 3:
                    {
                        dayValue = day[2];
                        break;
                    }
                case 4:
                    {
                        dayValue = day[3];
                        break;
                    }
                case 5:
                    {
                        dayValue = day[4];
                        break;
                    }
                case 6:
                    {
                        dayValue = day[5];
                        break;
                    }
                default:
                    {
                        dayValue = day[6];
                        break;
                    }
            }

            Console.WriteLine($"The day {dayNumber} is {dayValue}");
        }

        private static void Task6()
        {
            Console.WriteLine("--- Task 6 ---");

            decimal[] numbers = new decimal[9];
            byte quantityOfNegativeNumbers = 0;

            Console.WriteLine("Input 9 numbers.");

            for (byte index = 1; index < 10; index++)
            {
                Console.WriteLine($"-> Number {index}: ");
                while (!(decimal.TryParse(Console.ReadLine(), out numbers[index - 1])))
                    Console.WriteLine("Incorrect value entered. Please enter a number: ");
            }

            foreach (long number in numbers)
                if (number < 0)
                    quantityOfNegativeNumbers++;

            Console.WriteLine($"You entered {quantityOfNegativeNumbers} negative numbers.");
        }

        private static void Task7()
        {
            Console.WriteLine("--- Task 7 ---");

            byte[,] myArray = new byte[8, 5];

            for (byte row = 0; row < 8; row++)
                for (byte column = 0; column < 5; column++)
                    myArray[row, column] = (byte)new Random().Next(0, 100);

            Console.WriteLine("Array 8x5 with random numbers in (0, 99):");

            for (byte row = 0; row < 8; row++)
            {
                for (byte column = 0; column < 5; column++)
                    Console.Write($"{myArray[row, column]} ");
                Console.WriteLine();
            }
        }

        private static void Task8()
        {
            Console.WriteLine("--- Task 8 ---");

            byte[] firstArray = new byte[5];
            byte[] secondArray = new byte[5];

            float averageValueOfFirstArray = 0;
            float averageValueOfSecondArray = 0;

            Random randomNumber = new Random();

            for (byte index = 0; index < 5; index++)
            {
                firstArray[index] = (byte)randomNumber.Next(0, 6);
                secondArray[index] = (byte)randomNumber.Next(0, 6);
            }

            Console.WriteLine("First array with random numbers in (0, 5):");
            foreach (byte element in firstArray)
                Console.Write($"{element} ");

            Console.WriteLine();

            Console.WriteLine("Second array with random numbers in (0, 5):");
            foreach (byte element in secondArray)
                Console.Write($"{element} ");

            Console.WriteLine();

            foreach (byte element in firstArray)
            {
                averageValueOfFirstArray += element;
            }
            averageValueOfFirstArray /= firstArray.Length;

            foreach (byte element in secondArray)
            {
                averageValueOfSecondArray += element;
            }
            averageValueOfSecondArray /= secondArray.Length;

            if (averageValueOfFirstArray > averageValueOfSecondArray)
                Console.WriteLine($"Average value of numbers in the first array ({averageValueOfFirstArray}) is higher than in the second array ({averageValueOfSecondArray}).");
            else if (averageValueOfFirstArray < averageValueOfSecondArray)
                Console.WriteLine($"Average value of numbers in the first array ({averageValueOfFirstArray}) is lower than in the second array ({averageValueOfSecondArray}).");
            else
                Console.WriteLine($"Average value of numbers in the first array ({averageValueOfFirstArray}) is the same as in the second array ({averageValueOfSecondArray}).");
        }

        private static void Task9()
        {
            Console.WriteLine("--- Task 9 ---");

            int[] fibonacciNumbers = new int[20];
            fibonacciNumbers[0] = fibonacciNumbers[1] = 1;

            for (int i = 2; i < 20; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 2] + fibonacciNumbers[i - 1];
            }

            foreach (int fibonacciNumber in fibonacciNumbers)
                Console.Write($"{fibonacciNumber} ");
        }

        private static void Task10()
        {
            Console.WriteLine("--- Task 10 ---");

            int[] myArray = new int[11];

            int quantityOfMinusOnes = 0;
            int quantityOfZeros = 0;
            int quantityOfOnes = 0;

            Random randomNumber = new Random();

            for (int index = 0; index < 11; index++)
            {
                myArray[index] = randomNumber.Next(-1, 2);
            }

            foreach (int element in myArray)
                Console.Write($"{element} ");

            foreach (int element in myArray)
            {
                switch (element)
                {
                    case (-1):
                        {
                            quantityOfMinusOnes++;
                            break;
                        }

                    case (0):
                        {
                            quantityOfZeros++;
                            break;
                        }

                    case (1):
                        {
                            quantityOfOnes++;
                            break;
                        }
                }
            }

            Console.WriteLine();

            if (!((quantityOfMinusOnes == quantityOfZeros) || (quantityOfMinusOnes == quantityOfOnes) || (quantityOfOnes == quantityOfMinusOnes)))
            {
                if ((quantityOfMinusOnes > quantityOfZeros) && (quantityOfMinusOnes > quantityOfOnes))
                    Console.WriteLine($"-1 appears most times - {quantityOfMinusOnes}.");
                else if ((quantityOfZeros > quantityOfMinusOnes) && (quantityOfZeros > quantityOfOnes))
                    Console.WriteLine($"0 appears most times - {quantityOfZeros}.");
                else if ((quantityOfOnes > quantityOfMinusOnes) && (quantityOfOnes > quantityOfZeros))
                    Console.WriteLine($"1 appears most times - {quantityOfOnes}.");
            }
        }
    }
}