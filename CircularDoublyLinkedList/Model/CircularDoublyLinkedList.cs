using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;

namespace CircularDoublyLinkedList.Model
{
    public class CircularDoublyLinkedList<T> : IEnumerable<T>
    {
        public Item<T> Head { get; set; }
        public int Count { get; set; }

        public CircularDoublyLinkedList()
        {

        }

        public CircularDoublyLinkedList(T data)
        {
            SetHeadItem(data);
        }

        public void Add(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new Item<T>(data);
            item.Next = Head;
            item.Previous = Head.Previous;
            Head.Previous.Next = item;
            Head.Previous = item;
            Count++;
        }

        public void AddFirst(T data)
        {

            if (Head == null)
            {
                SetHeadItem(data);
            }
            else
            {
                var item = new Item<T>(data);
                item.Next = Head.Next;
                item.Previous = Head.Previous;
                Head = item;
                Count++;
            }
        }

        public void AddAfter(T target, T data)
        {
            var current = Head;
            for (int i = Count; i > 0; i--)
            {
                if (current != null && current.Data.Equals(target))
                {
                    var item = new Item<T>(data);
                    item.Next = current.Next;
                    current.Next = item;
                    Count++;
                    return;
                }
                current = current.Next;
            }
        }

        public void Remove(T data)
        {
            if (Head.Data.Equals(data))
            {
                RemoveItem(Head);
                Head = Head.Next;
                return;
            }
            var current = Head.Next;
            for (int i = Count; i > 0; i--)
            {
                if (current != null && current.Data.Equals(data))
                {
                    RemoveItem(current);
                }
                current = current.Next;
            }
        }

        private void RemoveItem(Item<T> current)
        {
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;
            Count--;
        }

        private void SetHeadItem(T data)
        {
            Head = new Item<T>(data);
            Head.Next = Head;
            Head.Previous = Head;
            Count = 1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            for (int i = 0; i < Count; i++)
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
