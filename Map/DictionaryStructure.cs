using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Map
{
    public class DictionaryStructure<TKey, TValue> : IEnumerable
    {
        private Item<TKey, TValue>[] _items;
        private List<TKey> _keys;
        private int _size = 100;
        public DictionaryStructure()
        {
            _items = new Item<TKey, TValue>[_size];
            _keys = new List<TKey>();
        }

        public void Add(Item<TKey, TValue> item)
        {
            var hash = GetHash(item.Key);

            if (_keys.Contains(item.Key))
            {
                return;
            }

            if (_items[hash] == null)
            {
                _keys.Add(item.Key);
                _items[hash] = item;
            }
            else
            {
                var isInLeft = false;
                for (int i = hash; i < _size; i++)
                {
                    if (_items[i] == null)
                    {
                        _keys.Add(item.Key);
                        _items[i] = item;
                        isInLeft = true;
                        break;
                    }

                    if (_items[i].Key.Equals(item.Key))
                    {
                        return;
                    }


                }
                if (!isInLeft)
                {
                    for (int i = 0; i < hash; i++)
                    {

                        if (_items[i] == null)
                        {
                            _keys.Add(item.Key);
                            _items[i] = item;
                            isInLeft = true;
                            break;
                        }

                        if (_items[i].Key.Equals(item.Key))
                        {
                            return;
                        }

                    }
                }

                if (!isInLeft)
                {
                    throw new Exception("Dictionary is full");
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }

        public void Remove(TKey key)
        {
            var hash = GetHash(key);

            if (!_keys.Contains(key))
            {
                return;
            }

            if (_items[hash] == null)
            {
                for (int i = 0; i < _size; i++)
                {
                    if (_items[i] != null && _items[i].Key.Equals(key))
                    {
                        _items[i] = null;
                        _keys.Remove(key);
                        return;
                    }
                }
                return;
            }
            if (_items[hash].Key.Equals(key))
            {
                _items[hash] = null;
                _keys.Remove(key);
            }
            else
            {
                var isInLeft = false;
                for (int i = hash; i < _size; i++)
                {
                    if (_items[i] == null)
                    {
                        return;
                    }

                    if (_items[i].Key.Equals(key))
                    {
                        _items[i] = null;
                        _keys.Remove(key);
                        return;
                    }


                }
                if (!isInLeft)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (_items[i] == null)
                        {
                            return;
                        }

                        if (_items[i].Key.Equals(key))
                        {
                            _items[i] = null;
                            _keys.Remove(key);
                            return;
                        }
                    }
                }
            }
        }

        public TValue Search(TKey key)
        {
            var hash = GetHash(key);


            if (!_keys.Contains(key))
            {
                return default(TValue);
            }

            if (_items[hash] == null)
            {
                foreach (var item in _items)
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }
                return default(TValue);
            }

            if (_items[hash].Key.Equals(key))
            {
                return _items[hash].Value;
            }

            var isInLeft = false;
            for (int i = hash; i < _size; i++)
            {

                if (_items[i] == null)
                {
                    return default(TValue);
                }

                if (_items[i].Key.Equals(key))
                {
                    return _items[i].Value;
                }
            }
            if (!isInLeft)
            {
                for (int i = 0; i < hash; i++)
                {
                    if (_items[i] == null)
                    {
                        return default(TValue);
                    }

                    if (_items[i].Key.Equals(key))
                    {
                        return _items[i].Value;
                    }
                }
            }
            return default(TValue);
        }

        private int GetHash(TKey key)
        {
            return key.GetHashCode() % _size;
        }
    }
}
