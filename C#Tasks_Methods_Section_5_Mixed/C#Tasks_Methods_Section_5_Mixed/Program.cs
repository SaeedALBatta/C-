using System.Collections.Generic;

namespace C_Tasks_Methods_Section_5_Mixed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 21: Compare Two Lists [Using New List]");
            CompareTwoLists();
            Console.WriteLine("_____________________");


            Console.WriteLine("Task 21: Compare Two Lists [USING LINQ Distincnt & Contains]");
            CompareTwoLists1();
            Console.WriteLine("_____________________");

            Console.WriteLine("Task 21: Compare Two Lists [USING Intersect()]");
            CompareTwoLists2();
            Console.WriteLine("_____________________");

            Console.WriteLine("Task 22: Merge Two Lists [2 for Each + distinct() + Orderby()] ");
            MergeTwoLists();
            Console.WriteLine("_____________________");

            Console.WriteLine("Task 22: Merge Two Lists [LINQ Concat() + distinct() + Orderby()]");
            MergeTwoLists1();
            Console.WriteLine("_____________________");


            Console.WriteLine("Task 22: Merge Two Lists [Union without duplacte defualt]");
            MergeTwoLists2();
            Console.WriteLine("_____________________");


            Console.WriteLine("Task 23: Unique Values Only [By Hand For Loop]");
            UniqueValuesOnly();
            Console.WriteLine("_____________________");

            Console.WriteLine("Task 23: Unique Values Only [LINQ GroupBy ,Where(), Select]");
            UniqueValuesOnly1();
            Console.WriteLine("_____________________");

            Console.WriteLine("Task 24: Dictionary to List [Bu Using new list And Two ForEach]");
            DictionarytoList();
            Console.WriteLine("_____________________");

            Console.WriteLine("Task 24: Dictionary to List [BY LINQ Students.Values.toList]");
            DictionarytoList1();
            Console.WriteLine("_____________________");


            Console.WriteLine("Task 25: Filter Dictionary");
            FilterDictionary();
            Console.WriteLine("_____________________");
        }

        static void CompareTwoLists()
        {
            List<int> Numbers1 = new List<int> { 1, 2, 3, 4, 24, 2, 4, 19, 20, 40, 14 };
            List<int> Numbers2 = new List<int> { 1, 2, 3, 20, 40, 14, 37, 38, 22, 89 };
            List<int> Numbers3 = new List<int>();

            foreach (var item in Numbers1)
            {
                if (Numbers2.Contains(item))
                {
                    Numbers3.Add(item);
                }
            }

            Numbers3 = Numbers3.Distinct()
                .OrderBy(x => x)
                .ToList();

            foreach (var item in Numbers3)
            {
                Console.WriteLine(item);
            }
        }

        static void CompareTwoLists1()
        {
            List<int> Numbers1 = new List<int> { 1, 2, 3, 4, 24, 2, 4, 19, 20, 40, 14 };
            List<int> Numbers2 = new List<int> { 1, 2, 3, 20, 40, 14, 37, 38, 22, 89 };

            var compare = Numbers1.Distinct()
                .Where(n => Numbers2.Contains(n))
                .OrderBy(n=> n);

            foreach (var item in compare)
            {
                Console.WriteLine(item);
            }
        }

        static void CompareTwoLists2()
        {
            List<int> Numbers1 = new List<int> { 1, 2, 3, 4, 24, 2, 4, 19, 20, 40, 14 };
            List<int> Numbers2 = new List<int> { 1, 2, 3, 20, 40, 14, 37, 38, 22, 89 };

            var Result = Numbers1.Intersect(Numbers2);
            foreach (var item in Result) 
            {
                Console.WriteLine(item);
            }
        }

        static void MergeTwoLists()
        {
            List<int> Numbers1 = new List<int> { 1, 2, 3, 4, 24, 2, 4, 19, 20, 40, 14 };
            List<int> Numbers2 = new List<int> { 1, 2, 3, 20, 40, 14, 37, 38, 22, 89 };

            foreach (var item in Numbers2) 
            {
                Numbers1.Add(item);
            }

            Numbers1 = Numbers1.OrderBy(n => n).Distinct().ToList();

            foreach (var item in Numbers1)
            {
                Console.WriteLine(item);
            }
        }
        static void MergeTwoLists1()
        {
            List<int> Numbers1 = new List<int> { 1, 2, 3, 4, 24, 2, 4, 19, 20, 40, 14 };
            List<int> Numbers2 = new List<int> { 1, 2, 3, 20, 40, 14, 37, 38, 22, 89 };

            var Result = Numbers1.Concat(Numbers2)
                .OrderBy(n => n)
                .Distinct();
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
        }

        static void MergeTwoLists2()
        {
            List<int> Numbers1 = new List<int> { 1, 2, 3, 4, 24, 2, 4, 19, 20, 40, 14 };
            List<int> Numbers2 = new List<int> { 1, 2, 3, 20, 40, 14, 37, 38, 22, 89 };

            var Result = Numbers1
                .Union(Numbers2);
                
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
        }

        static void UniqueValuesOnly()
        {
            List<int> Numbers1 = new List<int> {14, 1, 2, 20 , 3, 4, 24, 2, 4, 19, 20, 40, 14 };
            List<int> Result = new List<int>();

            for (int i =0; i < Numbers1.Count(); i++)
            {
                int Count = 0;
                for (int j = 0; j < Numbers1.Count(); j++)
                {
                    if (Numbers1[i] == Numbers1[j])
                    {
                        Count++;
                    }
                }
                if (Count == 1) 
                {
                    Result.Add(Numbers1[i]);
                }
            }
            foreach (var item in Result) 
            {
                Console.WriteLine(item);
            }
        }

        static void UniqueValuesOnly1()
        {
            List<int> Numbers1 = new List<int> { 14, 1, 2, 20, 3, 4, 24, 2, 4, 19, 20, 40, 14 };

            var Result = Numbers1
                .GroupBy(n => n)
                .Where(n=> n.Count()==1)
                .Select(n => n.Key)
                .ToList();

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
           
        }

        static void DictionarytoList()
        {
            Dictionary<string , int> Students = new Dictionary<string , int>();
            Students.Add("Saeed",90);
            Students.Add("Ahmad",29);
            Students.Add("Zaid",87);
            Students.Add("Lena",79);

            List<int> Grades = new List<int>();

            foreach (var item in Students) 
            {
                Grades.Add(item.Value);
            }
            foreach (var item in Grades)
            {
                Console.WriteLine(item);
            }
        }

        static void DictionarytoList1()
        {
            Dictionary<string, int> Students = new Dictionary<string, int>();
            Students.Add("Saeed", 90);
            Students.Add("Ahmad", 29);
            Students.Add("Zaid", 87);
            Students.Add("Lena", 79);

            var Grades = Students.Values.ToList();
            foreach (var item in Grades)
            {
                Console.WriteLine(item);
            }
        }

        static void FilterDictionary()
        {
            Dictionary<string, int> Students = new Dictionary<string, int>();
            Students.Add("Saeed", 920);
            Students.Add("Lana", 56);
            Students.Add("Ahmad", 249);
            Students.Add("Zaid", 867);
            Students.Add("Lena", 99);

            var Result = Students.Where(n => n.Value > 100);
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
