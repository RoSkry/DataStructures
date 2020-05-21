using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;

namespace SetStructure
{
    public class SetList<T> : IEnumerable
    {
        private List<T> _items = new List<T>();

        public int Count => _items.Count;

        public SetList()
        {

        }

        public SetList(IEnumerable<T> items)
        {
            _items = items.ToList();
        }
        public SetList(T item)
        {
            _items.Add(item);
        }

        public void Add(T item)
        {

            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (!_items.Contains(item))
            {
                _items.Add(item);
            }
        }

        public void Remove(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _items.Remove(item);
        }

        public SetList<T> Union(SetList<T> set)
        {
            // return new SetList<T>(_items.Union(set._items));

            if (set == null)
            {
                throw new ArgumentNullException(nameof(set));
            }

            var result = new SetList<T>();

            foreach (var item in _items)
            {
                result.Add(item);
            }

            foreach (var item in set._items)
            {
                result.Add(item);
            }
            return result;
        }

        public SetList<T> Intersection(SetList<T> set)
        {
            //   return new SetList<T>(items.Intersect(set.items));
            if (set == null)
            {
                throw new ArgumentNullException(nameof(set));
            }
            var result = new SetList<T>();

            if (this.Count < set.Count)
            {
                foreach (var item in this._items)
                {
                    if (set._items.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }

            else
            {
                foreach (var item in set._items)
                {
                    if (this._items.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }


            return result;
        }

        public SetList<T> Difference(SetList<T> set)
        {
            //   return new SetList<T>(items.Except(set.items));
            if (set == null)
            {
                throw new ArgumentNullException(nameof(set));
            }
            var result = new SetList<T>(_items);

            foreach (var item in set._items)
            {
                result.Remove(item);
            }

            return result;
        }

        public bool Subset(SetList<T> set)
        {
            //   return set.items.All(i => items.Contains(i));

            if (set == null)
            {
                throw new ArgumentNullException(nameof(set));
            }

            foreach (var item in set._items)
            {
                var equals = false;
                if(_items.Contains(item))
                {
                    equals = true;
                    break;
                }
                if (!equals)
                {
                    return false;
                }
            }
            return true;
        }

        public SetList<T> SymmetricDifference(SetList<T> set)
        {
            //  return new SetList<T>(items.Except(set.items).Union(set.items.Except(items));

            if (set == null)
            {
                throw new ArgumentNullException(nameof(set));
            }

            var result = new SetList<T>();

            foreach (var item in _items)
            {
                var equals = false;

                if(set._items.Contains(item))
                {
                    equals = true;
                   
                }

                if (!equals)
                {
                    result.Add(item);
                }
            }

            foreach (var item in set._items)
            {
                var equals = false;
                if (_items.Contains(item))
                {
                    equals = true;

                }

                if (!equals)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
