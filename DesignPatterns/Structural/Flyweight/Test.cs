using System;

namespace DesignPatterns.Structural.Flyweight
{
    public static class Test
    {
        public static void Run()
        {
            var keysFactory = new KeysFactory();
            var keyA1 = keysFactory.GetKey("A");
            var keyB1 = keysFactory.GetKey("B");
            var keyC1 = keysFactory.GetKey("C");

            Console.WriteLine("Created keyA1, keyB1, keyC1");

            var keyA2 = keysFactory.GetKey("A");
            var keyB2 = keysFactory.GetKey("B");
            var keyC2 = keysFactory.GetKey("C");

            Console.WriteLine("Created keyA2, keyB2, keyC2");

            if (keyA1 == keyA2)
            {
                Console.WriteLine("keyA1 and keyA2 are the same instance");
            }

            if (keyB1 == keyB2)
            {
                Console.WriteLine("keyB1 and keyB2 are the same instance");
            }

            if (keyC1 == keyC2)
            {
                Console.WriteLine("keyC1 and keyC2 are the same instance");
            }
        }
    }
}
