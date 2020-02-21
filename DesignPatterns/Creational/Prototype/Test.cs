using System;

namespace DesignPatterns.Creational.Prototype
{
    public static class Test
    {
        public static void Run()
        {
            IAnimal lion1 = new Lion(10);
            IAnimal lion2 = lion1.Clone();
            IAnimal lion3 = lion2.Clone();

            IAnimal tiger1 = new Tiger(20);
            IAnimal tiger2 = tiger1.Clone();

            Console.WriteLine($"Lion 1 age: {lion1.Age}");
            Console.WriteLine($"Lion 2 age: {lion2.Age}");
            Console.WriteLine($"Lion 3 age: {lion3.Age}");

            Console.WriteLine($"Tiger 1 age: {tiger1.Age}");
            Console.WriteLine($"Tiger 2 age: {tiger2.Age}");
        }
    }
}
