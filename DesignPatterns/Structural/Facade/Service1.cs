using System;

namespace DesignPatterns.Structural.Facade
{
    public class Service1 : IService1
    {
        public void DoOperationA()
        {
            Console.WriteLine("Operation A");
        }
    }
}
