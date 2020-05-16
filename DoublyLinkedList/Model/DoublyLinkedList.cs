using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList.Model
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public Item<T> Head { get; set; }
        public Item<T> Tail { get; set; }
        public int Count { get; set; }

        public DoublyLinkedList() { }

        public DoublyLinkedList(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (Head == null)
            {
                Head = item;
            }
            else
            {
                Tail.Next = item;
                item.Previous = Tail;
            }

            Tail = item;
            Count++;
        }

        public void Remove(T data)
        {
            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                Head.Previous = null;
                Count--;
                return;
            }
            if (Tail.Data.Equals(data))
            {
                Tail = Tail.Previous;
                Tail.Next = null;
                Count--;
                return;
            }

            var curent = Head;
            while (curent != null)
            {
                if (curent.Data.Equals(data))
                {
                    curent.Previous.Next = curent.Next;
                    curent.Next.Previous = curent.Previous;
                    Count--;
                    return;
                }
                curent = curent.Next;
            }
        }

        public void AddFirst(T data)
        {
            var item = new Item<T>(data);
            var current = Head;
            item.Next = current;
            Head = item;
            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                current.Previous = item;
            }
            Count++;
        }

        public void AddAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        item.Previous = current;
                        Count++;
                        return;
                    }
                    current = current.Next;
                }
            }
        }

        public bool Contains(T data)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void ClearAll()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public DoublyLinkedList<T> Reverse()
        {
            var result = new DoublyLinkedList<T>();
            var current = Tail;
            while (current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }

            return result;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }


    }
}
