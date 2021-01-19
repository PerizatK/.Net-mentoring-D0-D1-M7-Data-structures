using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_structures
{
    public class Node
    {
        public int data;
        public Node next;
        public Node previous;

        public Node(int d)
        {
            data = d;
            next = null;
            previous = null;
        }
    }

    public class MyLinkedList<T> : LinkedList<T>, IEnumerator<int>
    {
        public Node head;
        private int position = -1;

        public int Current()
        {
            if (position == -1 || position >= Length())
                throw new InvalidOperationException();
            return (this as LinkedList<int>).ElementAt(position);
        }

        object IEnumerator.Current => throw new NotImplementedException();

        int IEnumerator<int>.Current => throw new NotImplementedException();

        public int Length()
        {
            return this.Count();
        }
        public void Add(int newData)
        {
            Node newNode = new Node(newData); //creating new node
            newNode.next = this.head; // head of list is null if there are no nodes; old head will be 2nd node --last in first out (LIFO)
            this.head = newNode; //new node will be head now --last in first out (LIFO)
        }

        public void AddAt(Node oldNode, int newData)
        {
            if (oldNode == null)
                throw new InvalidOperationException("Previous node can not be null");
            Node new_node = new Node(newData);
            new_node.next = oldNode.next;
            oldNode.next = new_node;
        }

        public void Remove(int deleteData)
        {
            Node temp = this.head;
            Node prev = null;
            if (temp != null && temp.data == deleteData)
            {
                this.head = temp.next;
                return;
            }
            while (temp != null && temp.data != deleteData)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public void RemoveAt(Node deleteNode)
        {
            Node temp = this.head;
            Node prev = null;
            if (temp != null && temp == deleteNode)
            {
                this.head = temp.next;
                return;
            }
            while (temp != null && temp != deleteNode)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public bool MoveNext()
        {
            if (position < (Length() - 1))
            {
                position++;
                return true;
            }
            else return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
        }

        public int ElementAt(int index)
        {
            return this.Skip(index - 1).First();
        }
    }
}
