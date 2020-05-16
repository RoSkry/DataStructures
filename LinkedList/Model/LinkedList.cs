using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LinkedList.Model
{
    /// <summary>
    /// Linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// First element in list
        /// </summary>
        public Item<T> Head { get; set; }

        /// <summary>
        /// Last element in list
        /// </summary>
        public Item<T> Tail { get; set; }

        /// <summary>
        /// Total number of element in list
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Create empty list
        /// </summary>
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary>
        /// Create list with one element
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {

            SetHeadAndTail(data);
        }

        /// <summary>
        /// Add data in the end of list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Add data at the beginning
        /// </summary>
        /// <param name="data"></param>
        public void AppendFirst(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }

        /// <summary>
        /// Lis contains data
        /// </summary>
        public bool Contains(T data)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Insert data after target element
        /// </summary>
        /// <param name="target"></param>
        /// <param name="data"></param>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (true)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                //SetHeadAndTail(target);
                //Add(data);
            }
        }

        /// <summary>
        /// Remove data from list
        /// </summary>
        /// <param name="data"></param>
        public void Remove(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Clear list
        /// </summary>
        public void ClearAll()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Get all elements in list
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "Linked List " + Count;
        }
    }
}
