using System;

namespace HashTableStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var rightHashTable = new RightHashTable<Person>(100);

            var person = new Person { Name = "Vasya", Age = 25, Gender = 0 };
            rightHashTable.Add(new Person { Name = "Petya", Age = 35, Gender = 0 });
            rightHashTable.Add(new Person { Name = "Andrey", Age = 15, Gender = 0 });
            rightHashTable.Add(new Person { Name = "Katya", Age = 18, Gender = 1 });
            rightHashTable.Add(person);

            Console.WriteLine(rightHashTable.Search(new Person { Name = "Vasya", Age = 25, Gender = 0 }));
            Console.WriteLine(rightHashTable.Search(person));

            Console.WriteLine("**************************");

            var hashTable = new HashTable<int, string>(100);
            hashTable.Add(5, "Hello");
            hashTable.Add(18, "World");
            hashTable.Add(777, "Hi");
            hashTable.Add(7, "Program");

            Console.WriteLine(hashTable.Search(6, "Kirill"));
            Console.WriteLine(hashTable.Search(18, "World"));

            Console.WriteLine("**************************");

            var badHashTable = new BadHashTable<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);
            badHashTable.Add(7);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));
        }
    }
}
