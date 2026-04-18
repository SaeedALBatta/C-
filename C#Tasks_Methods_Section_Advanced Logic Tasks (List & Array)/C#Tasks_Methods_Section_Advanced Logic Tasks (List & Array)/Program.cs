using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Tasks_Methods_Section_Advanced_Logic_Tasks__List___Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: Hidden Pattern Finder");
            HiddenPatternFinder();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 2: Rotation Puzzle");
            //RoationPuzzle();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 3: Mirror Check");
            MirrorCheck();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 4: Missing Number Detective");
            MissingNumberDetective();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 5: Split List into Balanced Parts");
            SplitList();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 6: Longest Increasing Sequence");
            LongestIncreasingSqueunse();
            Console.WriteLine("__________________");

        }
        static void HiddenPatternFinder()
        {
            int[] Numbers = { 1,4,6, 7,2,1,8,4,5,1,2,3,4,5,6,7,8,8,9,2,9,4,3,5, 3, 4, 5, 6, 7, 8, 9 };
            int HigestCounter = 0;
            int MostNumberFrequant = 0;
            foreach (int num1 in Numbers)
            {
                int Counter = 0;
                foreach (int num2 in Numbers)
                {
                    if (num1 == num2)
                    {
                        Counter++;
                    }
                   
                }
                if (Counter > HigestCounter)
                {
                    HigestCounter = Counter;
                    MostNumberFrequant = num1;
                }
            }
            Console.WriteLine($"the number that appears the most {MostNumberFrequant} Appernes {HigestCounter}");
        }

        static void RoationPuzzle()
        {
            Console.WriteLine("enter How Many Steps do you need Rotate");
            int Step = Convert.ToInt32( Console.ReadLine() );

            int[] Numbers = [1, 2, 3, 4, 5];
            Step = Step % Numbers.Length;

            for (int i = 0; i < Numbers.Length; i++)
            {

            }
        }

        static void MirrorCheck()
        {
            int[] Numbers = [1, 2, 3, 2, 1];
            int End = Numbers.Length - 1;
            bool IsMirror = false;
            for (int i = 0 ; i < Numbers.Length; i++)
            {

                if (Numbers[i] == Numbers[End])
                {
                    IsMirror = true;
                    End--;
                }
                else
                {
                    IsMirror = false;
                }
            }
            if (!IsMirror)
            {
                Console.WriteLine("NOT Syumtric");
            }
            else
            {
                Console.WriteLine("Symutric");
            }
        }

        static void MissingNumberDetective()
        {
            int[] Numbers = { 1, 2,3, 4, 5, 7 };
            for (int i = 0; i < Numbers.Length-1; i++)
            {
                if (Numbers[i+1] - Numbers[i] != 1 )
                {
                    Console.WriteLine($"The Number Missing Is : {Numbers[i] + 1}");
                    break;
                }
            }
        }

        static void SplitList()
        {
            List<int> Numbers = new List<int> { 3, 1, 4, 2, 2 };
            int TotalSum = Numbers.Sum();
            int LeftSum = 0;

            int BestSplit = int.MaxValue ;
            int SplitIndex = -1;


            for (int i = 0; i < Numbers.Count - 1; i++)
            {
                LeftSum += Numbers[i];
                int rightSum = TotalSum - LeftSum;
                int diff = Math.Abs(LeftSum - rightSum);

                if (diff < BestSplit) 
                {
                    BestSplit = diff;
                    SplitIndex = i;
                }
            }
            Console.WriteLine($"Best Split at index: {SplitIndex}");
            Console.WriteLine($"min Difference: {BestSplit}");
            Console.Write("Left: ");
            for (int i = 0; i <= SplitIndex; i++)
            {
                Console.Write(Numbers[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Right: ");
            for (int i = SplitIndex + 1; i < Numbers.Count; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
            Console.WriteLine();
        }

        static void LongestIncreasingSqueunse()
        {
            int[] Numbers = [1, 2, 2, 3, 4, 1, 2, 3];

            int MaxLength = 1;
            int CurrentLength = 1;

            int Start = 0;
            int BestStart = 0;

            for (int i = 1; i < Numbers.Length; i++)
            {
                if (Numbers[i] == Numbers[i - 1] + 1)
                {
                    CurrentLength = i - Start + 1;
                }
                else 
                {
                    Start = i;
                    CurrentLength = 1;
                }
                if (CurrentLength > MaxLength)
                {
                    MaxLength = CurrentLength;
                    BestStart = Start;
                }
            }
            for (int i = BestStart; i < BestStart + MaxLength; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
        }

    }
}
