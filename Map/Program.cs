using System;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new DictionaryStructure<int, string>();

            dict.Add(new Item<int, string>(1, "One"));          
            dict.Add(new Item<int, string>(1, "One"));       
            dict.Add(new Item<int, string>(2, "Two"));
            dict.Add(new Item<int, string>(3, "Three"));
            dict.Add(new Item<int, string>(4, "Four"));
            dict.Add(new Item<int, string>(5, "Five"));
            dict.Add(new Item<int, string>(101, "One hundread one"));

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dict.Search(7) ?? "Not found");
            Console.WriteLine(dict.Search(3) ?? "Not found");
            Console.WriteLine(dict.Search(101) ?? "Not found");

            dict.Remove(7);
            dict.Remove(101);
            dict.Remove(3);
            dict.Remove(1);

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*************************");

            var simpleMap = new SimpleMap<int,string>();

            simpleMap.Add(new Item<int, string>(1,"One"));
            simpleMap.Add(new Item<int, string>(2, "Two"));
            simpleMap.Add(new Item<int, string>(3, "Three"));
            simpleMap.Add(new Item<int, string>(4, "Four"));
            simpleMap.Add(new Item<int, string>(5, "Five"));

            foreach (var item in simpleMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(simpleMap.Search(7)??"Not found");
            Console.WriteLine(simpleMap.Search(3) ?? "Not found");

            simpleMap.Remove(3);
            simpleMap.Remove(1);

            foreach (var item in simpleMap)
            {
                Console.WriteLine(item);
            }
        }
    }
}
