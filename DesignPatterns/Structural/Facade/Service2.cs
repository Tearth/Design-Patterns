using System;

namespace DesignPatterns.Structural.Facade
{
    public class Service2 : IService2
    {
        public void DoOperationB()
        {
            Console.WriteLine("Operation B");
        }
    }
}