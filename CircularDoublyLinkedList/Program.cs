using CircularDoublyLinkedList.Model;
using System;

namespace CircularDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var circularDoublyLinkedList = new CircularDoublyLinkedList<int>();
            circularDoublyLinkedList.Add(1);
            circularDoublyLinkedList.Add(2);
            circularDoublyLinkedList.Add(3);
            circularDoublyLinkedList.Add(4);
            circularDoublyLinkedList.Add(5);

            foreach (var item in circularDoublyLinkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            circularDoublyLinkedList.Remove(3);
            foreach (var item in circularDoublyLinkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            circularDoublyLinkedList.AddFirst(2020);
            foreach (var item in circularDoublyLinkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            circularDoublyLinkedList.AddAfter(2020,1996);
            foreach (var item in circularDoublyLinkedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
