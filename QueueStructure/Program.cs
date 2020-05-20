using QueueStructure.Model;
using System;

namespace QueueStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region QueueList
            Console.WriteLine("QueueList");
            var queueList = new QueueList<int>();
            queueList.Enqueue(1);
            queueList.Enqueue(2);
            queueList.Enqueue(3);
            queueList.Enqueue(4);
            queueList.Enqueue(5);

            Console.WriteLine(queueList.Dequeue());
            Console.WriteLine(queueList.Peek());
            Console.WriteLine(queueList.Dequeue());

            #endregion

            Console.WriteLine();

            #region QueueArray
            Console.WriteLine("QueueArray");

            var queueArray = new QueueArray<int>(5);
            queueArray.IsEmpty();
            queueArray.Enqueue(1);
            queueArray.Enqueue(2);
            queueArray.Enqueue(3);

            queueArray.IsFull();

            Console.WriteLine(queueArray.Dequeue());
            Console.WriteLine(queueArray.Peek());
            Console.WriteLine(queueArray.Dequeue());

            #endregion

            Console.WriteLine();

            #region QueueWithoutCount
            Console.WriteLine("QueueWithoutCount");
            var queueWithoutCount = new QueueWithoutCount<int>(5);
            queueWithoutCount.IsEmpty();
            queueWithoutCount.Enqueue(1);
            queueWithoutCount.Enqueue(2);
            queueWithoutCount.Enqueue(3);

            queueWithoutCount.Dequeue();
            #endregion

            Console.WriteLine();
            #region QueueLinkedList
            Console.WriteLine("QueueLinkedList");
            var queueLinkedList = new QueueLinkedList<int>(1);
            queueLinkedList.Enqueue(2);
            queueLinkedList.Enqueue(3);
            queueLinkedList.Enqueue(4);
            queueLinkedList.Enqueue(5);

            queueLinkedList.Dequeue();
            queueLinkedList.Peek();
            #endregion
        }
    }
}
