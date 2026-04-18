namespace C_Tasks_Methods_Section_3_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 11: Add Elements");
            AddElement();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 12: Remove Middle Element [i know size]");
            RemoveMiddelElement();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 12: Remove Middle Element [Middel By Count/2]");
            RemoveMiddelElement1();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 12: Remove Middle Element [Middel By Slow & Fast Pointer]");
            RemoveMiddelElement2();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 13: Add Before/After");
            AddBefore_After();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 14: Traverse LinkedList");
            Traverse();
            Console.WriteLine("__________________");

            Console.WriteLine("Task 15: First and Last");
            FirstandLast();
            Console.WriteLine("__________________");


        }

        static void AddElement()
        {
            LinkedList<string> Element = new LinkedList<string>();
            Element.AddFirst("One");
            Element.AddLast("Three");
            Element.AddLast("Five");

            LinkedListNode<string> FirstNode = Element.First;
            Element.AddAfter(FirstNode,"Two");

            LinkedListNode<string> MiddelNode = Element.Last;
            Element.AddBefore(MiddelNode,"Four");


            foreach (var item in Element)
            {
                Console.WriteLine(item);
            }
        }

        static void RemoveMiddelElement()
        {
            LinkedList<string> Element = new LinkedList<string>();
            Element.AddFirst("One");
            Element.AddLast("Three");
            Element.AddLast("Five");

            LinkedListNode<string> MiddelNode = Element.First.Next;
            Element.Remove(MiddelNode);

            foreach(var item in Element)
            {
                Console.WriteLine(item);
            }
        }

        static void RemoveMiddelElement1()
        {
            LinkedList<string> Element = new LinkedList<string>();
            Element.AddFirst("One");
            Element.AddLast("Three");
            Element.AddLast("Five");

            int middelindex = Element.Count / 2;

            LinkedListNode<string> Current = Element.First;

            for (int i = 0; i < middelindex; i++) 
            {
                Current = Current.Next;
            }

            Element.Remove(Current);
            foreach (var item in Element)
            {
                Console.WriteLine(item);
            }
        }

        static void RemoveMiddelElement2()
        {
            LinkedList<string> Element = new LinkedList<string>();
            Element.AddFirst("One");
            Element.AddLast("Three");
            Element.AddLast("Five");

            LinkedListNode<string> Slow = Element.First;
            LinkedListNode<string> Fast = Element.First;

            while (Fast != null && Fast.Next != null)
            {
                Slow = Fast.Next;
                Fast = Fast.Next.Next;
            }
            Element.Remove(Slow);
            foreach(var item in Element)
            {
                Console.WriteLine(item);
            }
        }

        static void AddBefore_After()
        {
            LinkedList<string> Element = new LinkedList<string>();
            Element.AddFirst("One");
            Element.AddLast("Three");
            Element.AddLast("Five");

            LinkedListNode <string> firstNode = Element.First;
            Element.AddAfter(firstNode,"Two");

            LinkedListNode<string> lastNode = Element.Last;
            Element.AddBefore(lastNode,"Four");

            foreach(var item in Element)
            {
                Console.WriteLine(item);
            }
        }

        static void Traverse()
        {
            LinkedList<string> Element = new LinkedList<string>();
            Element.AddFirst("One");
            Element.AddLast("Three");
            Element.AddLast("Five");

            Console.WriteLine("Printing Useing Foreach");
            foreach (var item in Element)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("_____");
            Console.WriteLine("Printing Useing LinkedList Node [Current - While]");

            LinkedListNode<string> Current = Element.First;
            while (Current != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
        }

        static void FirstandLast()
        {
            LinkedList<string> Element = new LinkedList<string>();
            Element.AddFirst("One");
            Element.AddLast("Three");
            Element.AddLast("Five");

            if (Element.First != null && Element.Last != null)
            {
                Console.WriteLine(Element.First.Value);
                Console.WriteLine(Element.Last.Value);
            }
            
        }

    }
}
