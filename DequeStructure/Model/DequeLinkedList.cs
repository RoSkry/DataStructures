using System;
using System.Collections.Generic;
using System.Text;

namespace DequeStructure.Model
{
    public class DequeLinkedList<T>
    {
        private Item<T> _head;
        private Item<T> _tail;
        public int Count { get; private set; }
        public DequeLinkedList()
        {

        }
        public DequeLinkedList(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            var item = new Item<T>(data);
            _head = item;
            _tail = item;
            Count = 1;
        }

        public void AddLast(T data)
        {
            if(Count==0)
            {
                SetHeadItem(data);
                return;
            }
            var item = new Item<T>(data);
            _tail.Next = item;
            item.Previous = _tail;
            _tail = item;
            Count++;
        }

        public void AddFirst(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }
            var item = new Item<T>(data);
            _head.Previous = item;
            item.Next = _head;
            _head = item;
            Count++;
        }

        public T PopLast()
        {
            if (Count == 0)
                throw new NullReferenceException("Deque is empty");
            var result = _tail.Data;
            if(Count == 1)
            {
                _head = _tail = null;
            }
            else
            {
                _tail = _tail.Previous;
                _tail.Next = null;
            }
            Count--;
            return result;
        }

        public T PopFirst()
        {
            if (Count == 0)
                throw new NullReferenceException("Deque is empty");
            var result = _head.Data;
            if (Count == 1)
            {
                _head = _tail = null;
            }
            else
            {
                _head = _head.Next;
                _head.Previous = null;
            }
            Count--;
            return result;
        }

        public T PeekLast()
        {
            return _tail.Data;
        }

        public T PeekFirst()
        {
            return _head.Data;
        }
    }
}
