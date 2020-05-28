using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    public class Heap
    {
        private List<int> _items = new List<int>();
        public int Count => _items.Count;

        public int? Peek()
        {
            if (Count > 0)
            {
                return _items[0];
            }
            else
            {
                return default(int);
            }
        }

        public void Add(int item)
        {
            _items.Add(item);
            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);

            while (currentIndex > 0 && _items[parentIndex] < _items[currentIndex])
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        public int GetMax()
        {

            var result = _items[0];
            _items[0] = _items[Count - 1];
            _items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int currentIndex)
        {
            int  leftIndex, rightIndex;
            int maxIndex= currentIndex;
            while (currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if(_items[leftIndex] > _items[maxIndex])
                {
                    maxIndex = leftIndex;
                }

                if (_items[rightIndex] > _items[maxIndex])
                {
                    maxIndex = rightIndex;
                }

                if (maxIndex==currentIndex)
                {
                    break;
                }

                Swap(currentIndex,maxIndex);
                currentIndex = maxIndex;

            }
        }

        private void Swap(int currentIndex, int parentIndex)
        {
            var temp = _items[currentIndex];
            _items[currentIndex] = _items[parentIndex];
            _items[parentIndex] = temp;
        }

        private int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }
    }
}
