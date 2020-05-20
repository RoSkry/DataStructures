using System;
using System.Collections.Generic;
using System.Text;

namespace QueueStructure.Model
{
   public class Item <T>
    {
        public T Data { get; set; }
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }
    }
}
