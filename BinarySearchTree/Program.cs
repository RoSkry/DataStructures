using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);
            tree.Add(4);

            foreach (var item in tree.PreOrder())
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            foreach (var item in tree.PostOrder())
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            foreach (var item in tree.InOrder())
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine(tree.Search(3));
            Console.WriteLine(tree.Search(123));

            Console.WriteLine(tree.Max());
            Console.WriteLine(tree.Min());

            Console.WriteLine(tree.Remove(9));

            foreach (var item in tree.InOrder())
            {
                Console.Write(item + ", ");
            }
        }
    }
}
