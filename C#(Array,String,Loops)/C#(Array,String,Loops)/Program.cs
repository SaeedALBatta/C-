using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Array_String_Loops_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 15, 22, 7, 8, 13, 30 };

            //AnalyzeArray(numbers);
            //largestNumberInArray();
            //PrintNumbersFrom1To10();
            //PrintEvenNubers();
            //DataConversion();
            //TaskString();
            TaskBreak_Contioue();
        }

        static void AnalyzeArray(int[] numbers)
        {
            int evenCount = 0;
            int oddCount = 0;
            int sumNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;

                sumNumbers += numbers[i];
            }

            int avg = sumNumbers / numbers.Length;

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > avg)
                {
                    count++;
                }
            }

            int[] filteredArray = new int[count];
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > avg)
                {
                    filteredArray[index] = numbers[i];
                    index++;
                }
            }
            Console.WriteLine($"Even Count : {evenCount}");
            Console.WriteLine($"Odd Count : {oddCount}");
            Console.WriteLine($"Sum : {sumNumbers}");
            Console.WriteLine($"AVG : {avg}");
            Console.WriteLine($"Filtered Array : {string.Join(", ", filteredArray)}");
        }
        static void largestNumberInArray()
        {
            int[] Numbers = [12, 45, 7, 23, 56, 19];
            int MaxNumber = Numbers[0] ;
            foreach (int number in Numbers)
            {
                if (number > MaxNumber)
                {
                    MaxNumber = number ;
                }
            }
            Console.WriteLine($"The Largest Number In Array : {MaxNumber}");
        }

        static void PrintNumbersFrom1To10()
        {
            Console.WriteLine("Print numbers from 1 → 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintEvenNubers()
        {
            Console.WriteLine("Print only even numbers");
            for (int i = 1;i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void DataConversion() {

            Console.WriteLine("Please Enter The Full Name:");
            string FullName = Console.ReadLine();

            Console.WriteLine("Please Enter Your Age:");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Your Height in meters:");
            double Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter If You Employed (true / false)");
            bool isEmployed = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("--- User Profile ---\r\n");
            Console.WriteLine($"Name : {FullName}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Height :{Height}");
            Console.WriteLine($"Employed : {isEmployed}");
        }

        static void TaskString()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            string upperName = name.ToUpper();
            string lowerName = name.ToLower();

            Console.WriteLine($"Upper Case: {upperName}");
            Console.WriteLine($"Lower Case: {lowerName}");

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string sentence1 = "My name is " + name + " and I am " + age + " years old.";
            Console.WriteLine(sentence1);

            string sentence2 = $"My name is {name} and I am {age} years old.";
            Console.WriteLine(sentence2);

            char firstLetter = name[0];
            Console.WriteLine($"First letter: {firstLetter}");

            char lastLetter = name[name.Length - 1];
            Console.WriteLine($"Last letter: {lastLetter}");

        }
        static void TaskBreak_Contioue()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                if (i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}