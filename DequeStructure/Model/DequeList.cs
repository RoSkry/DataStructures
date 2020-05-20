using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace DequeStructure.Model
{
    public class DequeList<T>
    {
        private List<T> _items = new List<T>();
        private T Head => _items.Last();
        private T Tail => _items.First();
        public int Count => _items.Count;
        public DequeList()
        {

        }
        public DequeList(T data)
        {
            _items.Add(data);
        }

        public void AddLast(T data)
        {
            _items.Insert(0, data);
        }

        public void AddFirst(T data)
        {
            _items.Add(data);
        }

        public T PopLast()
        {
            var item = Tail;
            _items.Remove(item);
            return item;
        }

        public T PopFirst()
        {
            var item = Head;
            _items.Remove(item);
            return item;
        }

        public T PeekLast()
        {
            return Tail;
        }

        public T PeekFirst()
        {
            return Head;
        }
    }
}
