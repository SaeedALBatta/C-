using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Tasks_Discord_Function_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("returns the number of days between the first and second date. ");
            Console.WriteLine(GetDays(new DateTime(2019, 6, 14), new DateTime(2019, 6, 20)));
            Console.WriteLine(GetDays(new DateTime(2018, 12, 29), new DateTime(2019, 1, 1)));
            Console.WriteLine("_______________________");

            Console.WriteLine(" returns an array with only the strings \r\nthat have numbers in them.");
            Console.WriteLine(string.Join(", ", NumberInString(new string[] { "1a", "a", "2b", "b" })));
            Console.WriteLine(string.Join(", ", NumberInString(new string[] { "abc", "abc10" })));
            Console.WriteLine("_______________________");

            Console.WriteLine(ReverseOdd("Saeed Samer Al-Batta"));
            Console.WriteLine(ReverseOdd("One two three four"));

            Console.WriteLine(isPandigitalNumber(98140723568910)); // true
            Console.WriteLine(isPandigitalNumber(90864523148909)); // false
            Console.WriteLine(isPandigitalNumber(112233445566778899)); // false
        }
        static int GetDays(DateTime date1 , DateTime date2)
        {
            TimeSpan difference = date2 - date1;
            return difference.Days;
        }

        static List<string> NumberInString(string[] arr)
        {
            List<string> result = new List<string>();
            foreach (string str in arr) 
            {
                foreach (char c in str)
                {
                    if (char.IsDigit(c))
                    {
                        result.Add(str);
                        break;
                    }
                }
            }
            return result;
        }
        static string ReverseOdd (string Sentence)
        {
            string[] Word = Sentence.Split(' ');
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i].Length % 2 != 0)
                {
                    char[] koko = Word[i].ToCharArray();
                    Array.Reverse(koko);
                    Word[i] = new string (koko);
                }
            }
            return string.Join(" ", Word);
        }

        static bool isPandigitalNumber(long Number)
        {
            List<int> AllNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var NumberList = Number.ToString();

            foreach (char c in NumberList) 
            {
                int digit = c - '0';
                AllNumbers.Remove(digit);

            }
            return AllNumbers.Count == 0;

        }
    }
}
