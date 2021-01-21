using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    public class HybridFlowProcessor<T> : LinkedList<T>, IHybridFlowProcessor<T>
    {
        /*LIFO*/
        public void Push(T item)
        {
            Add(item);
        }
        public T Pop()
        {
            var node = ElementAt(0);
            RemoveAt(0);
            return node;
        }
        /*FIFO*/
        public void Enqueue(T item)
        {
            Add(item);
        }
        public T Dequeue()
        {
            return ElementAt(0);
        }
    }
}
