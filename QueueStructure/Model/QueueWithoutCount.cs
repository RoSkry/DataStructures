using System;
using System.Collections.Generic;
using System.Text;

namespace QueueStructure.Model
{
    public class QueueWithoutCount<T>
    {
        private int _maxSize;
        private T[] _items;
        private int _head;
        private int _tail;

        public QueueWithoutCount(int size)
        {
            _maxSize = size + 1;
            _items = new T[_maxSize];
            _head = 0;
            _tail = -1;
        }

        public void Enqueue(T data)
        {
            if (IsFull())
                throw new OverflowException("Queue is full");

            _items[++_tail] = data;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new NullReferenceException("Queue is empty");
            
            var result = _items[_head++];
            return result;
        }

        public T Peek()
        {
            return _items[_head];
        }

        public bool IsEmpty()
        {
            return _tail + 1 == _head;
        }

        public bool IsFull()
        {
            return  _head + _maxSize - 2 == _tail;
        }

        public int GetSize() 
        {
            if (_tail >= _head) 
                return _tail - _head + 1;
            else 
                return (_maxSize - _head) + (_tail + 1);
        }
    }
}
