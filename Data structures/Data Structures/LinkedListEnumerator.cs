using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    public class LinkedListEnumerator<T> : IEnumerator
    {
        LinkedList<T> list;
        int position = -1;
        public LinkedListEnumerator(LinkedList<T> list)
        {
            this.list = list;
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= list.Length())
                    throw new InvalidOperationException();
                return list.ElementAt(position);
            }
        }

        public bool MoveNext()
        {
            if (position < list.Length() - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
