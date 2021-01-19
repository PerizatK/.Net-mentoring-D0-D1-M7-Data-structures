using System;
using System.Collections.Generic;

namespace Data_structures
{
    class Program
    {
        private LinkedList<int> linkedList;
        static void Main(string[] args)
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.AddAt(list.ElementAt(1), 5);

        }
    }
}
