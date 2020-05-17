using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace StackStructure.Model
{
    public class StackLinked<T>
    {
        public Item<T> Head { get; set; }
        public int Count { get; set; }

        public bool IsEmpty
        {
            get { return Count == 0; }
        }

        public StackLinked()
        {
            Head = null;
            Count = 0;
        }

        public StackLinked(T data)
        {            
            Head = new Item<T>(data);
            Count = 1;
        }

        public void Push(T data)
        {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new NullReferenceException("Stack is empty");
            var item = Head;
            Head = item.Previous;
            Count--;
            return item.Data;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new NullReferenceException("Stack is empty");
            return Head.Data;
        }
    }
}
