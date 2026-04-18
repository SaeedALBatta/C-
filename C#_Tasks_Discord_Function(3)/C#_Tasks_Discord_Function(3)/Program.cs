using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Tasks_Discord_Function_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Given a number, n, return a function which adds n to the number passed to it. ");
            Console.WriteLine(AddNToNumber(10,20));
            Console.WriteLine(AddNToNumber(0, 20));
            Console.WriteLine(AddNToNumber(-30, 80));
            Console.WriteLine("____________________");


            Console.WriteLine("2) Create a function that takes in a number as a string n and returns the number without \r\ntrailing and  leading zeros. ");
            Console.WriteLine(ClearNumberFromZeros("0001203000"));
            Console.WriteLine(ClearNumberFromZeros("00100"));
            Console.WriteLine("____________________");

            Console.WriteLine("second largest number.");
            Console.WriteLine(SecondeLargestNumber([10,20,40,30,50]));
            Console.WriteLine("____________________");

            Console.WriteLine("is Repdigit");
            Console.WriteLine(isRepdigit(999));
            Console.WriteLine(isRepdigit(123));
            Console.WriteLine(isRepdigit(00));
            Console.WriteLine("____________________");


            Console.WriteLine(ReversWords("The Sky is Blue"));

            Console.WriteLine("____________________");
            Console.WriteLine(InsertWhiteSpases("SaeedSamerAlbattaFullStackDevoloper"));
            Console.WriteLine("____________________");
            Console.WriteLine(CountTrue([true, false, false, true, false]));
            Console.WriteLine("____________________");

            Console.WriteLine(CapetailToFront("moveMENT"));
            Console.WriteLine("+___________________");

            Console.WriteLine(matchLastItem([1, 1, 1, "11"]));
            Console.WriteLine("____________________");

            Console.WriteLine(findNaN(([1, 2,double.NaN ])));
            Console.WriteLine("____________________");



        }
        static int AddNToNumber(int N , int Number)
        {
            return N + Number;
        }

        static string ClearNumberFromZeros(string Number)
        {
            int start = 0;
            int end = Number.Length - 1;
            for (int i = 0; i < Number.Length; i++)
            {
                if (Number[i] != '0')
                {
                    start = i;
                    break;
                }
            }
            for (int i = Number.Length - 1; i >= 0; i--)
            {
                if (Number[i] != '0')
                {
                    end = i;
                    break;
                }
            }
            return Number.Substring(start, end - start + 1);
        }

        static int SecondeLargestNumber(int[] Numbers)
        {
            var Rselt = Numbers.OrderByDescending(n => n)
                .Skip(1)
                .First();
            return Rselt;
        }

        static bool isRepdigit(int Number)
        {
            if (Number <= 0)
                return false;

            string numStr = Number.ToString();

            char first = numStr[0];

            foreach (char c in numStr)
            {
                if (c != first)
                    return false;
            }

            return true;
        }
        static string ReversWords(string Sentence)
        {
            string[] Words = Sentence.Split(' ');
            Array.Reverse(Words);
            return string.Join(" ", Words);
        }

        static string SevenBoom(int[] numbers)
        {
            foreach (int num in numbers)
            {
                if (num.ToString().Contains('7'))
                {
                    return "Boom!";
                }
            }

            return "there is no 7 in the array";
        }

        static string InsertWhiteSpases(string Sentnse)
        {
            string result = "";
            for (int i = 0 ; i < Sentnse.Length ; i++) 
            {
                result += Sentnse[i];
                if (i < Sentnse.Length - 1 && char.IsLower(Sentnse[i]) && char.IsUpper(Sentnse[i + 1]))
                {
                    result += " ";
                }
            }
            return result;
        }

        static int CountTrue(bool[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString().ToLower() == "true")
                count++;
            }
            return count;

        }

        static string CapetailToFront(string word)
        { 
            string upper = "";
            string lower = "";

            foreach (char c in word)
            {
                if (char.IsUpper(c))
                    upper += c;
                else
                    lower += c;
            }

            return upper + lower;
        }

        static bool matchLastItem(object[] Items)
        {
            string Result = "";
            for (int i = 0; i < Items.Length - 1; i++)
            {
                Result += Items[i].ToString();
            }
            if (Result == Items[Items.Length - 1])
            {
                return true;
            }
            return false;
        }

        static int findNaN(double[] Items)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (double.IsNaN(Items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        //static object removeDuos(object[] Items)
        //{
        //    for (int i = 0; i < Items.Length; i++) 
        //    {

        //    }

        //}
    }
}
