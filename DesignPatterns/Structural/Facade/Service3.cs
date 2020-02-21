using System;

namespace DesignPatterns.Structural.Facade
{
    public class Service3 : IService3
    {
        public void DoOperationC()
        {
            Console.WriteLine("Operation C");
        }
    }
}