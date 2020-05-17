using StackStructure.Model;
using System;
using System.Collections;

namespace StackStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackArray = new StackArray<int>(3);

            stackArray.Push(1);
            stackArray.Push(2);
            stackArray.Push(3);
            stackArray.Push(4);

            var item = stackArray.Pop();
            Console.WriteLine(item);

            item = stackArray.Peek();
            Console.WriteLine(item);

            while (!stackArray.IsEmpty)
            {
                var item1 = stackArray.Pop();
                Console.WriteLine(item1);
            }
        }
    }
}
