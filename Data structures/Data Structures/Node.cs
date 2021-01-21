using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; } // данные которые содержит элемент
        public Node<T> Next { get; set; } //указатель на след.элемент списка

        public Node<T> Previous { get; set; } // указатель на предыд.элемент для двойного списка
    }
}


