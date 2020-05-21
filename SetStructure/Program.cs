using System;

namespace SetStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var setList1 = new SetList<int>(new int[] { 1, 2, 3, 4, 5 });
            var setList2 = new SetList<int>(new int[] { 4, 5, 6, 7, 8 });
            var setList3 = new SetList<int>(new int[] { 3,4,5});

            Console.Write("Union: ");
            foreach (var item in setList1.Union(setList2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Intersection: ");
            foreach (var item in setList1.Intersection(setList2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Difference A\\B: ");
            foreach (var item in setList1.Difference(setList2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Difference B\\A: ");
            foreach (var item in setList2.Difference(setList1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("C Subset A: ");
            Console.Write(setList1.Subset(setList3));
            Console.WriteLine();

            Console.Write("A Subset C: ");
            Console.Write(setList3.Subset(setList1));
            Console.WriteLine();

            Console.Write("B Subset A: ");
            Console.Write(setList3.Subset(setList1));
            Console.WriteLine();

            Console.Write("Symmetric Difference: ");
            foreach (var item in setList1.SymmetricDifference(setList2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
