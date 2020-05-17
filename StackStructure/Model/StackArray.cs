using System;
using System.Collections.Generic;
using System.Text;

namespace StackStructure.Model
{
    public class StackArray<T>
    {
        private T[] items;
        private int count;
        public int CountInArray { get; } = 10;
        public StackArray()
        {
            items = new T[CountInArray];
        }
        public StackArray(int lenght)
        {
            items = new T[lenght];
        }
        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public void Push(T item)
        {
            if (count == items.Length)
                Resize(items.Length + 10);
            items[count++] = item;
        }

        private void Resize(int max)
        {
            T[] tempItems = new T[max];
            for (int i = 0; i < count; i++)
            {
                tempItems[i] = items[i];
            }
            items = tempItems;
        }

        public T Pop()
        {
            if(IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            T item = items[--count];
            items[count] = default(T);

            if (count > 0 && count < items.Length - 10)
                Resize(items.Length - 10);

            return item;
        }

        public T Peek()
        {
            return items[count - 1];
        }
    }
}
