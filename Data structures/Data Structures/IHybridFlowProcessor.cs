using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    interface IHybridFlowProcessor<T>
    {
        void Push(T item)
        {
        }
        T Pop()
        {
            return default;
        }
        void Enqueue(T item)
        { }
        T Dequeue()
        {
            return default;
        }

    }

}
