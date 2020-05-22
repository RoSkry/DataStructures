using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableStructure
{
    public class RightHashTable<T>
    {
        private Item<T>[] _items;

        public RightHashTable(int size)
        {
            _items = new Item<T>[size];

            for (int i = 0; i < _items.Length; i++)
            {
                _items[i] = new Item<T>(i);
            }
        }

        public void Add(T item)
        {
            var key = GetHash(item);
            _items[key].Nodes.Add(item);
        }

        public bool Search(T item)
        {
            var key = GetHash(item);
            return _items[key].Nodes.Contains(item);
        }

        public int GetHash(T item)
        {
            return item.GetHashCode() % _items.Length;
        }
    }
}
