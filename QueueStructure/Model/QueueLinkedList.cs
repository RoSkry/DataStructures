using System;
using System.Collections.Generic;
using System.Text;

namespace QueueStructure.Model
{
    public class QueueLinkedList<T>
    {
        private Item<T> _head;
        private Item<T> _tail;

        public int Count { get; private set; }

        public QueueLinkedList() { }

        public QueueLinkedList(T data)
        {
            SetHeadItem(data);

        }

        private void SetHeadItem(T data)
        {
            var item = new Item<T>(data);
            _head = item;
            _tail = _head;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (IsEmpty)
            {
                SetHeadItem(data);
                return;
            }

            var item = new Item<T>(data);
          
            _tail.Next = item;
            _tail = _tail.Next;
            Count++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new NullReferenceException("Queue is empty");
            var result = _head.Data;
            _head = _head.Next;
            Count--;
            return result;
        }

        public T Peek()
        {
            return _head.Data;
        }

        public bool IsEmpty { get { return Count == 0; } }
    }
}
