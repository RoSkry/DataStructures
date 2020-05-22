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

            var person1 = new Person { Name = "Vasya", Age = 35, Gender = 0, Id = 1 };
            var person2 = new Person { Name = "Vanya", Age = 15, Gender = 0, Id = 2 };
            var person3 = new Person { Name = "Petya", Age = 18, Gender = 1, Id = 3 };



            var hashTable = new HashTable<int, Person>(10);
            hashTable.Add(person1.Id, person1);
            hashTable.Add(person2.Id, person2);
            hashTable.Add(person3.Id, person3);


            Console.WriteLine(hashTable.Search(person1.Id, person1));
            Console.WriteLine(hashTable.Search(10, person1));

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
