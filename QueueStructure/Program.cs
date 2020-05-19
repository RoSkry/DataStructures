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

            var queueArray = new QueueArray<int>(10);
            queueArray.Enqueue(1);
            queueArray.Enqueue(2);
            queueArray.Enqueue(3);
            queueArray.Enqueue(4);
            queueArray.Enqueue(5);

            Console.WriteLine(queueArray.Dequeue());
            Console.WriteLine(queueArray.Peek());
            Console.WriteLine(queueArray.Dequeue());

            #endregion

        }
    }
}
