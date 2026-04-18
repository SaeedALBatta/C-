namespace C__Tasks_Discord_Function_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("function that takes an integer minutes and converts it to seconds.");
            Console.WriteLine($"The seconde Per Minutes = {MintutesToSeconds(12)}");
            Console.WriteLine("___________________________");

            Console.WriteLine("increments the number by +1 ");
            Console.WriteLine(IncrementByOne(7));
            Console.WriteLine("___________________________");

            Console.WriteLine(" function that takes an array containing only numbers and return the first element.");
            Console.WriteLine(FirstElementInArray(new int[] {2,4,5,3,8,9,0 }));
            Console.WriteLine("___________________________");

            Console.WriteLine("a function that takes the base and height of a triangle and return its area");
            Console.WriteLine(TringlrArea(3.6 , 6.3));
            Console.WriteLine("___________________________");

            Console.WriteLine("return a new array that have the even number in even index ");
            int[] Numbers = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };

            int[] Result = evenNumberEvenIndex(Numbers);

            foreach (int x in Result)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("___________________________");


            Console.WriteLine(" return a new array that have the string with odd length in even index");
            string[] Words = ["alex", "mercer", "madrasa", "rashed2", "emad", "hala"];

            string[] Result1 = evenIndexOddLength(Words);

            foreach (string x in Result1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("___________________________");

            int[] nums = { 44, 5, 4, 3, 2, 10 };

            int[] output = powerElementIndex(nums);

            foreach (int x in output)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("___________________________");

            Console.WriteLine(multiplication2(2,8));
            Console.WriteLine("___________________________");

            Console.WriteLine(muti2(3,6));
            Console.WriteLine("___________________________");

            int[] nums1 = { 1, 2, 3, 8, 9 };
            int[] nums2 = { 1, 2, 3, 8, 9, 77 };

            Console.WriteLine(aveArray(nums1)); 
            Console.WriteLine(aveArray(nums2)); 


        }
        static int MintutesToSeconds(int Minutes)
        {
            return Minutes * 60;
        }

        static int IncrementByOne(int Number)
        {
            return Number + 1;
        }

        static int FirstElementInArray(int[] Numbers)
        {
            return Numbers[0];
        }

        static double TringlrArea(double Base , double Height)
        {
            return Base * Height;
        }

        static int[] evenNumberEvenIndex(int[] Numbers)
        {
            int[] Temp = new int[Numbers.Length];
            int j = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] % 2 == 0 && i%2==0)
                {
                    Temp[j] = Numbers[i];
                    j++;
                }
            }
            int[] Result = new int[j];
            for (int i = 0;i < j; i++)
            {
                Result[i] = Temp[i];
            }
            return Result;
        }

        static string[] evenIndexOddLength(string[] Words)
        {
            string[] Temp = new string[Words.Length];
            int j = 0;
            for (int i = 0; i < Words.Length; i++)
            {
                if (i % 2 ==0 && Words[i].Length % 2 != 0 )
                {
                    Temp[j] = Words[i];
                    j++;
                }
            }
            string[] Result1 = new string[j];
            for (int i = 0; i < j; i++)
            {
                Result1[i] = Temp[i];
            }
            return Result1;
        }

        static int[] powerElementIndex(int[] Numbers)
        {
            int[] Temp = new int[Numbers.Length];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Temp[i] = (int)Math.Pow(Numbers[i] , i);
            }
            return Temp;
        }
        static int multiplication2(int Num1 , int Num2)
        {
            int Sum = 0;
            for (int i = 0; i < Num1; i++)
            {
                Sum += Num2;
            }
            return Sum;
        }

        static int muti2(int Num1 , int Num2)
        {
            int Multuple = 1;
            for (int i = Num1; i <= Num2; i++ )
            {
                Multuple = Multuple * i; 
            }
            return Multuple;
        }

        static double aveArray(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return (double)sum / nums.Length;
        }
    }
}
