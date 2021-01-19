using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    public class LinkedList<T> : IEnumerable<T>  // односвязный список
    {
        Node<T> head; // первый элемент
        Node<T> last; // последний элемент
        private bool isDoubleList = false;
        int count;  // количество элементов в списке
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public int position = -1;

        public LinkedList(bool isDoubleList = false)
        {
            this.isDoubleList = isDoubleList;
        }

        // добавление элемента
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
            {
                last.Next = node;
                node.Previous = last;
            }
            last = node;

            count++;
        }

        public void AddAt(T oldData, T newData)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(oldData))
                {
                    current.Data = newData;
                    current.Previous = previous;
                }

                previous = current;
                current = current.Next;
            }
        }

        // удаление элемента
        public bool RemoveAt(T data)
        {
            if (isDoubleList)
            {
                Node<T> current = head;

                // поиск удаляемого узла
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        break;
                    }
                    current = current.Next;
                }
                if (current != null)
                {
                    // если узел не последний
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        // если последний, переустанавливаем tail
                        last = current.Previous;
                    }

                    // если узел не первый
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        // если первый, переустанавливаем head
                        head = current.Next;
                    }
                    count--;
                    return true;
                }
            }
            else
            {
                Node<T> current = head;
                Node<T> previous = null;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        // Если узел в середине или в конце
                        if (previous != null)
                        {
                            // убираем узел current, теперь previous ссылается не на current, а на current.Next
                            previous.Next = current.Next;
                            // Если current.Next не установлен, значит узел последний,
                            // изменяем переменную last
                            if (current.Next == null)
                                last = previous;
                        }
                        else
                        {
                            // если удаляется первый элемент
                            // переустанавливаем значение head
                            head = head.Next;

                            // если после удаления список пуст, сбрасываем last
                            if (head == null)
                                last = null;
                        }
                        count--;
                        return true;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            return false;
        }

        // очистка списка
        public void Remove()
        {
            head = null;
            last = null;
            count = 0;
        }

        // Возвращает элемент по позиции
        public T ElementAt(int position)
        {
            Node<T> current = head;
            int i = 0;
            while (current != null)
            {
                if (i == position)
                    return current.Data;
                current = current.Next;
                i++;
            }
            return default;
        }

        public int Length()
        {
            return count;
        }

        public LinkedListEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
