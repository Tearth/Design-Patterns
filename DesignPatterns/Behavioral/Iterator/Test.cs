using System;

namespace DesignPatterns.Behavioral.Iterator
{
    public static class Test
    {
        public static void Run()
        {
            var collection = new Collection<int> {1, 2, 3, 4, 5, 6, 7, 8};
            var iterator = collection.CreateIterator();

            for (var item = iterator.First(); !iterator.IsDone(); item = iterator.Next())
            {
                Console.WriteLine(item);
            }
        }
    }
}
