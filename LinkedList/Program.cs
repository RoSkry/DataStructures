using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            list.Remove(3);
            list.Remove(5);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.AppendFirst(123);
            list.AppendFirst(12);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.InsertAfter(4, 2020);
            list.InsertAfter(4, 20);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var value = 2; 
            
            Console.WriteLine($"Contains {value}: {list.Contains(value)}");

            value = 5;
            Console.WriteLine($"Contains {value}: {list.Contains(value)}");
            Console.ReadLine();
        }
    }
}
