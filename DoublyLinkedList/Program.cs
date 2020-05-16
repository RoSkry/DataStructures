using DoublyLinkedList.Model;
using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublyList = new DoublyLinkedList<int>();
            doublyList.Add(1);
            doublyList.Add(2);
            doublyList.Add(3);
            doublyList.Add(4);
            doublyList.Add(5);

            foreach (var item in doublyList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            doublyList.Remove(5);
            foreach (var item in doublyList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var reverse = doublyList.Reverse();
            foreach (var item in reverse)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            doublyList.AddFirst(24);
            foreach (var item in doublyList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            doublyList.AddAfter(4, 2020);
            foreach (var item in doublyList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}
