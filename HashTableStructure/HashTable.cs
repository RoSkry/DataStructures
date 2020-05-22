using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableStructure
{
    public class HashTable<TKey,TValue>
    {
        private List<TValue>[] _items;

        public HashTable(int size)
        {
            _items = new List<TValue>[size];
        }

        public void Add(TKey key, TValue value)
        {
            var k = GetHash(key);
            if(_items[k]==null)
            {
                _items[k] = new List<TValue>() { value };
            }
            _items[k].Add(value);
        }

        public bool Search(TKey key, TValue value)
        {
            var k = GetHash(key);
            return _items[k]?.Contains(value)??false;
        }

        private int GetHash(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));
        }
    }
}
