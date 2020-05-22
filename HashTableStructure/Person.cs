using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableStructure
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
