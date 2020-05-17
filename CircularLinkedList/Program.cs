using CircularLinkedList.Model;
using System;

namespace CircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var circularLinkedList = new CircularLinkedList<int>(1);
            circularLinkedList.Add(2);
            circularLinkedList.Add(3);
            circularLinkedList.Add(4);
            circularLinkedList.Add(5);
            foreach (var item in circularLinkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            circularLinkedList.Remove(3);
            foreach (var item in circularLinkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"{circularLinkedList.Contains(22)}");

            circularLinkedList.AddFirst(100);
            foreach (var item in circularLinkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            circularLinkedList.AddAfter(4,2020);
            foreach (var item in circularLinkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
