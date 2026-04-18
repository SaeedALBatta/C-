namespace C_Tasks_Methods_Section_6_ThinkingTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 26: Manual Search [Using Loop Anf If]");
            ManuaulSearch();
            Console.WriteLine("______________________");

            Console.WriteLine("Task 26: Manual Search [Using LINQ]");
            ManuaulSearch1();
            Console.WriteLine("______________________");

            Console.WriteLine("Task 27: Count Even Without LINQ [Count Even Uing While]");
            CountEvenUingWhile();
            Console.WriteLine("______________________");

            Console.WriteLine("Task 27: Count Even Without LINQ [Count Even Uing For]");
            CountEvenUingFor();
            Console.WriteLine("______________________");

            Console.WriteLine("Task 27: Count Even LINQ");
            CountEvenUingLINQ();
            Console.WriteLine("______________________");

            Console.WriteLine("Task 28: Remove While Looping");
            RemoveWhileLooping();
            Console.WriteLine("______________________");


            Console.WriteLine("Task 29: Find Second Largest Number");
            FindSecondLargestNumber();
            Console.WriteLine("______________________");

            Console.WriteLine("Seconde Using LINQ SKIP()");
            SecondeLargestNumber();
        }
        static void ManuaulSearch()
        {
            Console.WriteLine("Eneter What Number Do Search?");
            int Num = Convert.ToInt32(Console.ReadLine());

            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6,78, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            bool Founded = false;
            for (int i = 0; i < Numbers.Count(); i++)
            {
                if (Num == Numbers[i])
                {
                    Console.WriteLine($"The Number {Num} Is Founded");
                    Founded = true;
                    break;
                }
            }
            if (!Founded)
            {
                Console.WriteLine("NOT FOUNDED");
            }
        }
        static void ManuaulSearch1()
        {
            Console.WriteLine("Eneter What Number Do Search?");
            int Num = Convert.ToInt32(Console.ReadLine());

            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            bool Founded = Numbers.Any(n => n==Num);
            Console.WriteLine(Founded ? "Founded" : "Not Founded");
        }

        static void CountEvenUingWhile()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 78, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int i = 0;
            int Count = 0;
            while (i < Numbers.Count)
            {
                if (Numbers[i] % 2 == 0)
                {
                    Count++;
                }
                ++i;
            }
            Console.WriteLine(Count);
        }

        static void CountEvenUingFor()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 78, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int Count = 0;
            for (int i = 0; i<Numbers.Count; i++)
            {
                if (Numbers[i] % 2 == 0)
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }

        static void CountEvenUingLINQ()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 78, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var Result = Numbers.Where(n => n % 2 == 0)
                .Count();
            Console.WriteLine(Result);
        }

        static void RemoveWhileLooping()
        {
            // Shifting Problem When Removeing Element 
            // Best Seloution Is Start remove From Last 
            // Make The Loop From Last 

            // Or USe RemoveAll(n => n % 2 == 0){ LINQ }
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 78, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int i = Numbers.Count - 1;
            while (i >= 0)
            {
                if (Numbers[i] % 2 == 0)
                {
                    Numbers.RemoveAt(i);
                }
                i--;
            }
            int j = 0;
            while (j < Numbers.Count)
            {
                Console.WriteLine(Numbers[j]);
                j++;
            }
        }

        static void FindSecondLargestNumber()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 78, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int max1 = 0;
            int max2 = 0;

            foreach (var number in Numbers) 
            {
                if (number > max1)
                {
                    max2 = max1;
                    max1 = number;
                }
                else if (number > max2 && number < max1)
                {
                    max2 = number;
                }
            }
            Console.WriteLine($"Seconde Largest Number : {max2}");
                         
        }

        static void SecondeLargestNumber()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 78, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var SecondeMax = Numbers.Distinct()
                .OrderByDescending(x => x)
                .Skip(1)
                .FirstOrDefault();
            Console.WriteLine(SecondeMax);
        }
    }
}
