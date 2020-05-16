using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Model
{
    public class Item<T>
    {
        private T data = default(T);
        private Item<T> next = null;
    }
}
