using DequeStructure.Model;
using System;

namespace DequeStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DequeList
            Console.WriteLine("DequeList");
            var deqList = new DequeList<int>();
            deqList.AddFirst(1);
            deqList.AddFirst(2);
            deqList.AddFirst(3);

            deqList.AddLast(10);
            deqList.AddLast(20);

            deqList.AddFirst(4);
            deqList.AddLast(500);
            Console.WriteLine(deqList.PopLast());
            Console.WriteLine(deqList.PopFirst());
            Console.WriteLine(deqList.PopLast());
            Console.WriteLine(deqList.PopFirst());
            #endregion

            Console.WriteLine();

            #region DequeList
            Console.WriteLine("DequeLinkedList");
            var deqLinkedList = new DequeLinkedList<int>();
            deqLinkedList.AddFirst(1);
            deqLinkedList.AddFirst(2);
            deqLinkedList.AddFirst(3);

            deqLinkedList.AddLast(10);
            deqLinkedList.AddLast(20);

            deqLinkedList.AddFirst(4);
            deqLinkedList.AddLast(500);
            Console.WriteLine(deqLinkedList.PopLast());
            Console.WriteLine(deqLinkedList.PopFirst());
            Console.WriteLine(deqLinkedList.PopLast());
            Console.WriteLine(deqLinkedList.PopFirst());
            #endregion

        }
    }
}
