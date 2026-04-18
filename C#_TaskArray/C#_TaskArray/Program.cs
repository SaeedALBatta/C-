namespace C__TaskArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstNonRepeatinSubarray();
        }
        static void FirstNonRepeatinSubarray()
        {
            int[] Numbers = { 1, 2, 1, 3 , 4 };
            int[] temp = [];

            int start = 0;
            for (int i = start ; i < Numbers.Length; i++)
            {
                temp[i] = i;
                if (Numbers[i+1] > temp[i] )
                {
                    temp[i + 1] = Numbers[i + 1];
                    break;
                }
            }
        }
    }
}
