using StackStructure.Model;
using System;
using System.Collections;

namespace StackStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            #region StackArray
            Console.WriteLine("StackArray");
            var stackArray = new StackArray<int>(3);

            stackArray.Push(1);
            stackArray.Push(2);
            stackArray.Push(3);
            stackArray.Push(4);

            var item = stackArray.Pop();
            Console.WriteLine(item);

            item = stackArray.Peek();
            Console.WriteLine(item);

            while (!stackArray.IsEmpty)
            {
                var item1 = stackArray.Pop();
                Console.WriteLine(item1);
            }
            #endregion
            Console.WriteLine();
            #region StackList
            Console.WriteLine("StackList");
            var stackList = new StackList<int>();

            stackList.Push(1);
            stackList.Push(2);
            stackList.Push(3);
            stackList.Push(4);
            stackList.Push(5);

            var stackListItem = stackList.Pop();
            Console.WriteLine(stackListItem);
            stackListItem = stackList.Peek();
            Console.WriteLine(stackListItem);
            #endregion
            Console.WriteLine();
            #region StackLinked 
            Console.WriteLine("StackLinked");
            var linkedStack = new StackLinked<int>();
            linkedStack.Push(5);
            linkedStack.Push(10);
            //linkedStack.Push(15);
            //linkedStack.Push(20);
            //linkedStack.Push(25);
          

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());

            #endregion
        }
    }
}
