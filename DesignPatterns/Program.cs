using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            //Creational.AbstractFactory.Test.Run();
            //Creational.Builder.Test.Run();
            //Creational.FactoryMethod.Test.Run();
            Creational.Singleton.Singleton.Instance.WriteHello();
            Console.Read();
        }
    }
}
