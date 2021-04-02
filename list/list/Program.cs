using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementCollection = new ElementCollection();
            var elementCollectionStack = new ElementCollectionStack();

            int[] array = new int[] { 5, 10, 15, 20, 25 };
            foreach ( var element in array)
            {
                elementCollection.Enqueue(element);
                elementCollectionStack.Push(element);
            }

            var sizeCollection = elementCollection.Count;

            Console.WriteLine("Работа с Очередью: ");
            for (var i = 1; i <= sizeCollection; i++)
            {
                Console.WriteLine($"Получил значение: {elementCollection.Peek()}");
                Console.WriteLine($"Удалил значение: {elementCollection.Dequeue()}");
            }
            Console.WriteLine("");



            Console.WriteLine("Работа со Стеком: ");
            for (var i = 1; i <= sizeCollection; i++)
            {
                Console.WriteLine($"Получил значение: {elementCollectionStack.Pop()}");
                Console.WriteLine($"Удалил значение: {elementCollectionStack.Peek()}");
            }

            Console.ReadKey();
        }
    }
}
