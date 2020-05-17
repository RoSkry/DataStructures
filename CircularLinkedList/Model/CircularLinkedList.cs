using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;

namespace CircularLinkedList.Model
{
    public class CircularLinkedList<T> : IEnumerable<T>
    {
        public Item<T> Head { get; set; }
        public Item<T> Tail { get; set; }
        public int Count { get; set; }

        public CircularLinkedList()
        {

        }

        public CircularLinkedList(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Tail.Next = Head;
            Count = 1;
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (Head == null)
            {
                Head = item;
                Tail = item;
                Tail.Next = Head;
            }
            else
            {
                item.Next = Head;
                Tail.Next = item;
                Tail = item;
            }
            Count++;
        }

        public void Remove(T data)
        {
            var current = Head;
            Item<T> previous = null;

            if (Count == 0) return;

            do
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current == Tail)
                        {
                            Tail = previous;
                        }
                    }
                    else
                    {
                        if (Count == 1)
                        {
                            Head = Tail = null;
                        }
                        else
                        {
                            Head = current.Next;
                            Tail.Next = current.Next;
                        }
                    }
                    Count--;
                }
                previous = current;
                current = current.Next;

            } while (current != Head);
        }

        public void AddFirst(T data)
        {
            var item = new Item<T>(data);
            if (Head == null)
            {
                Head = item;
                Tail = item;
                Tail.Next = Head;
            }
            else
            {
                Tail.Next = item;
                item.Next = Head;
                Head = item;
            }
        }

        public void AddAfter(T target, T data)
        {
            var current = Head;
            if (current == null) return;
            do
            {
                if (current.Data.Equals(target))
                {
                    var item = new Item<T>(data);
                    item.Next = current.Next;
                    current.Next = item;
                }
                current = current.Next;
            }
            while (current != Head);

        }

        public bool Contains(T data)
        {
            var current = Head;
            if (current == null) return false;
            do
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            while (current != Head);
            return false;
        }

        public void ClearAll()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            do
            {
                if (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }

            } while (current != Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
