namespace C_Tasks_Methods_Section_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6: Student Scores");
            StudentScore();
            Console.WriteLine("__________________________");

            Console.WriteLine("Task 6: Student Scores");
            StudentScore1();
            Console.WriteLine("__________________________");

            Console.WriteLine("Task 7: Search by Key");
            SearchbyKey();
            Console.WriteLine("__________________________");

            Console.WriteLine("Task 8: Sum of Values");
            SumOfValues();
            Console.WriteLine("__________________________");

            Console.WriteLine("Task 9: Remove Low Scores");
            RemoveLowScore();
            Console.WriteLine("__________________________");

            Console.WriteLine(" Task 10: Highest Score");
            HighestScore();
            Console.WriteLine("__________________________");

            Console.WriteLine(" Task 10: Highest Score");
            Hieghestscore1();
            Console.WriteLine("__________________________");

        }

        static void StudentScore()
        {
            Dictionary<string, int> Student = new Dictionary<string, int>();
            Student.Add("Saeed_1", 89);
            Student.Add("Saeed_2", 83);
            Student.Add("Saeed_3", 49);
            Student.Add("Saeed_4", 100);
            Student.Add("Saeed_5", 23);

            foreach (var item in Student)
            {
                if (item.Value >= 80)
                {
                    Console.WriteLine(item.Key + ":" + item.Value);
                }
            }

        }
        static void StudentScore1()
        {
            Dictionary<string, int> Student = new Dictionary<string, int>();
            Student.Add("Saeed_1", 89);
            Student.Add("Saeed_2", 83);
            Student.Add("Saeed_3", 49);
            Student.Add("Saeed_4", 100);
            Student.Add("Saeed_5", 23);

            var Result = Student.Where(n => n.Value >= 80);

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

        }

        static void SearchbyKey()
        {
            Console.WriteLine("Please Enter Youe Name To Return The Score");
            string Name  = Console.ReadLine();

            Dictionary<string, int> Student = new Dictionary<string, int>();
            Student.Add("Saeed_1", 89);
            Student.Add("Saeed_2", 83);
            Student.Add("Saeed_3", 49);
            Student.Add("Saeed_4", 100);
            Student.Add("Saeed_5", 23);

            if (Student.ContainsKey(Name))
            {
                Console.WriteLine($"{Name} : {Student[Name]}");
            }else
            {
                Console.WriteLine("Student Not Found");
            }
        }

        static void SumOfValues()
        {
            Dictionary<string, int> Student = new Dictionary<string, int>();
            Student.Add("Saeed_1", 89);
            Student.Add("Saeed_2", 83);
            Student.Add("Saeed_3", 49);
            Student.Add("Saeed_4", 100);
            Student.Add("Saeed_5", 23);

            var Sum = Student.Sum(n => n.Value);
            Console.WriteLine(Sum);
            // Return One Value No Need For Foreach(){}; Error
        }

        static void RemoveLowScore()
        {
            Dictionary<string, int> Student = new Dictionary<string, int>();
            Student.Add("Saeed_1", 89);
            Student.Add("Saeed_2", 83);
            Student.Add("Saeed_3", 49);
            Student.Add("Saeed_4", 100);
            Student.Add("Saeed_5", 23);

            var LowScore = Student.Where(n=> n.Value < 50);
            foreach (var n in LowScore) 
            {
                Student.Remove(n.Key);
            }

            foreach (var n in Student)
            {
                Console.WriteLine(n);
            }
        }

        static void HighestScore()
        {
            Dictionary<string, int> Student = new Dictionary<string, int>();
            Student.Add("Saeed_1", 89);
            Student.Add("Saeed_2", 83);
            Student.Add("Saeed_3", 49);
            Student.Add("Saeed_4", 100);
            Student.Add("Saeed_5", 23);

            var hihestScore = Student.MaxBy(n => n.Value);
            Console.WriteLine(hihestScore);
        }

        static void Hieghestscore1()
        {
            Dictionary<string, int> Student = new Dictionary<string, int>();
            Student.Add("Saeed_1", 89);
            Student.Add("Saeed_2", 83);
            Student.Add("Saeed_3", 49);
            Student.Add("Saeed_4", 100);
            Student.Add("Saeed_5", 23);

            var hiest = Student.OrderByDescending(n => n.Value)
                .First();

            Console.WriteLine(hiest);
        }

        


    }
}
