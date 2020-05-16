using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Model
{
    /// <summary>
    /// Cell of list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T>
    {    
        private T data = default(T);

        /// <summary>
        /// data in cel of list
        /// </summary>
        public T Data
        {
            get { return data; }
            set
            {
                data = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        /// <summary>
        /// Next cell in list
        /// </summary>
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
