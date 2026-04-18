using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Task_LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ZizagNumbers();
            //MirrorNumberPattern();
            CenteredNumberPyramid();


        }
        static void ZizagNumbers()
        {
            Console.WriteLine("Please Enter Number :");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++) 
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }
                else
                {
                    for (int j = i ; j > 0 ; j--)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }


        }

        static void MirrorNumberPattern()
        {
            Console.WriteLine("Please Enetr number :");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\t");
                for (int j = i ;j > 0 ; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void CenteredNumberPyramid()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int s = 1; s <= (i-n); s++)
                {
                    Console.WriteLine( " ");
                }
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write(j);
                }
                //for (int j = 1; j == i; j++)
                //{
                //    Console.Write(j);
                //}
                for (int j = i - 1 ; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
