using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueStructure.Model
{
    public class QueueArray<T>
    {
        private T[] _items;
        private int _head = 0;
        private int _tail = -1;
        private int _size;
        public int _count;
        public int Size
        {
            get { return _size; }
        }

        public int Count
        {
            get { return _count; }
        }

        public QueueArray(int size)
        {
            _size = size;
            _items = new T[size];
        }

        public QueueArray(int size, T data)
        {
            _size = size;
            _items = new T[size];
            _items[0] = data;
            _count = 1;
        }

        public void Enqueue(T data)
        {
            if (IsFull())
                throw new OverflowException("Queue is full");

                _items[++_tail] = data;
                _count++;        
        }

        public T Dequeue()
        {
            if (this.IsEmpty())
                throw new NullReferenceException("Queue is empty");
            T result = _items[_head++];
            _count--;
           return result;
        }

        public T Peek()
        {
            if (this.IsEmpty())
                throw new NullReferenceException("Queue is empty");
            return _items[_head+1];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _tail == _size - 1;
        }
    }
}
