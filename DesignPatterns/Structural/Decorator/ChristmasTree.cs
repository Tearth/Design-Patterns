using System;

namespace DesignPatterns.Structural.Decorator
{
    public class ChristmasTree : ITree
    {
        public void WriteInfo()
        {
            Console.Write("Christmas tree");
        }
    }
}
