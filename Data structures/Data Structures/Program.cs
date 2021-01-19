using System;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList:");
            {
                LinkedList<int> list = new LinkedList<int>();
                list.Add(5);
                list.AddAt(5, 6);
                list.Add(7);
                list.Add(8);

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"ElementAt(1) {list.ElementAt(1)}");
            }
            Console.WriteLine("DoubleLinkedList:");
            {
                LinkedList<int> doublelist = new LinkedList<int>();
                doublelist.Add(5);
                doublelist.AddAt(5, 6);
                doublelist.Add(7);
                doublelist.Add(8);

                foreach (var item in doublelist)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"ElementAt(1) {doublelist.ElementAt(1)}");
            }
            Console.ReadKey();



        }
    }
}
