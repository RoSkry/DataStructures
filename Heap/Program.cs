using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            var rnd = new Random();
            var statItems = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                statItems.Add(rnd.Next(-1000,1000));
            }
            timer.Start();
               var heap = new Heap(statItems);
            timer.Stop();
            Console.WriteLine("First initialization " + timer.Elapsed);
            timer.Reset();

            timer.Restart();
            for (int i = 0; i < 10; i++)
            {
                heap.Add(rnd.Next(-1000, 1000));
            }
            timer.Stop();
            Console.WriteLine("Add second thousand " + timer.Elapsed);

            timer.Restart();
            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Get 2000 " + timer.Elapsed);
        }
    }
}
