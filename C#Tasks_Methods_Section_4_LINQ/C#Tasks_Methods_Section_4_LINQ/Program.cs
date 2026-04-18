namespace C_Tasks_Methods_Section_4_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 16: Odd Numbers");
            OddNumbers();
            Console.WriteLine("___________________");


            Console.WriteLine("Task 17: Multiply All Numbers");
            MultiplyNumbers();
            Console.WriteLine("___________________");

            Console.WriteLine("Task 18: Sort Descending");
            SortDescending();
            Console.WriteLine("___________________");

            Console.WriteLine("Task 19: First Number Greater Than 100");
            FirstNumberGraterThan100();
            Console.WriteLine("___________________");

            Console.WriteLine("Task 19: First Number Greater Than 100");
            FirstNumberGraterThan100___1();
            Console.WriteLine("___________________");


            Console.WriteLine("Task 20: Average Calculation [Using Sum AND Count]");
            AVGCALCULATION();
            Console.WriteLine("___________________");

            Console.WriteLine("Task 20: Average Calculation [Average()]");
            AVG_CALCULATION();
            Console.WriteLine("___________________");


        }
        static void OddNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var odd = numbers.Where(n => n % 2 != 0);
            foreach (int n in odd)
            {
                Console.WriteLine(n);
            }
        }

        static void MultiplyNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var MultiplyALLNumbers = numbers.Select(n=> n * 2);
            foreach (int n in MultiplyALLNumbers)
            {
                Console.WriteLine(n);
            }
        }

        static void SortDescending()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,445,335,120,251,1000};
            var Sorting = numbers.OrderByDescending(n => n);
            foreach (int n in Sorting)
            {
                Console.WriteLine(n);
            }
        }

        static void FirstNumberGraterThan100()
        {
            List<int> numbers = new List<int> { 1, 2, 3,101, 4, 5, 6, 7, 8, 9, 445, 335, 120, 251, 1000 };
            var FirstNumber = numbers.Where(n => n > 100)
                .OrderBy(n => n)
                .First();

            Console.WriteLine(FirstNumber);
        }

        static void FirstNumberGraterThan100___1()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 101, 4, 5, 6, 7, 8, 9, 445, 335, 120, 251, 1000 };
            var FirstNumber = numbers.First(n => n > 100);
            Console.WriteLine(FirstNumber);
        }

        static void AVGCALCULATION()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 101, 4, 5, 6, 7, 8, 9, 445, 335, 120, 251, 1000 };
            var AVG = numbers.Sum() / numbers.Count();
            Console.WriteLine(AVG);
        }

        static void AVG_CALCULATION()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 101, 4, 5, 6, 7, 8, 9, 445, 335, 120, 251, 1000 };
            Console.WriteLine(numbers.Average());
        }
    }
}
