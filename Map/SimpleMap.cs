using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class SimpleMap<TKey, TValue>:IEnumerable
    {
        private List<Item<TKey, TValue>> _items = new List<Item<TKey, TValue>>();
        private List<TKey> _keys=new List<TKey>();

        public int Count => _items.Count;
        public SimpleMap()
        {

        }

        public void Add(Item<TKey, TValue> item)
        {
            if(!_keys.Contains(item.Key))
            {
                _keys.Add(item.Key);
                _items.Add(item);
            }
        }

        public TValue Search(TKey key)
        {
            if (_keys.Contains(key))
            {
                return _items.Single(i=>i.Key.Equals(key)).Value;
            }
            return default(TValue);
        }

        public void Remove(TKey key)
        {
            if (_keys.Contains(key))
            {
                _keys.Remove(key);
                _items.Remove(_items.Single(i => i.Key.Equals(key)));
            }
        }

        public IEnumerator GetEnumerator()
        {
           return _items.GetEnumerator();
        }
    }
}
